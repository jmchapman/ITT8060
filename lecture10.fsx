#r "FsCheck"

open FsCheck

// Basic checking

let revRevIsOrigInt (xs : list<int>) = List.rev (List.rev xs) = xs

(*
  Check with the following expression:

    Check.Quick revRevIsOrigInt
*)

// Failing check

let revIsOrigInt (xs : list<int>) = List.rev xs = xs

(*
  Note that the counter example is shrunk.
*)

// Verbose checking

(*
  Verbose checking is possible with the following expression:
  
    Check.Verbose revIsOrig

  It is helpful if we have nontermination.
*)

// Problem with floats

let revRevIsOrigFloat (xs : list<float>) = List.rev(List.rev xs) = xs

// Properties with polymorphic types

(*
  The type variables default to type Object. Values of various simple types are
  generated.
*)

let revRevIsOrig xs = List.rev(List.rev xs) = xs

let revIsOrig xs = List.rev xs = xs

// Conditional properties

let rec ordered xs =
  match xs with
    | [] | [_]       -> true
    | x1 :: x2 :: xs -> x1 <= x2 && ordered (x2 :: xs)

let rec insert x xs =
  match xs with
    | []      -> [x]
    | y :: ys -> if x <= y then x :: y :: ys else y :: insert x ys

let insertKeepsOrderBad (x : int) xs =
  if ordered xs then ordered (insert x xs) else true

let insertKeepsOrder (x : int) xs = ordered xs ==> ordered (insert x xs)

// Quantified properties

let orderedList = Arb.from<list<int>> |> Arb.mapFilter List.sort ordered
let insertKeepsOrder' x =
  Prop.forAll orderedList (fun xs -> ordered (insert x xs))

// Observing test case distribution

let insertKeepsOrderWithTrivial x xs =
  insertKeepsOrder x xs |> Prop.trivial (List.length xs = 0)

(*
  Trivial test cases may occur quite often when ==> is used.
*)

let insertKeepsOrderWithClassify x xs =
  insertKeepsOrder x xs
    |> Prop.classify (ordered (x :: xs))  "at beginning"
    |> Prop.classify (ordered (xs @ [x])) "at end"

let insertKeepsOrderWithCollect x xs =
  insertKeepsOrder x xs |> Prop.collect (List.length xs)

let insertKeepsOrderWithSeveral x xs =
  insertKeepsOrder x xs
    |> Prop.classify (ordered (x :: xs))  "at beginning"
    |> Prop.classify (ordered (xs @ [x])) "at end"
    |> Prop.collect (List.length xs)

// Conjunctions and labels

let complex (n : int) (m: int) =
  let res = n + m
  (res >= n)     .&.
  (res >= m)     .&.
  (res <> n + m) 

let complexWithLabels (n: int) (m: int) =
  let res = n + m
  (res >= n)     |@ "result >= #1"    .&.
  (res >= m)     |@ "result >= #2"    .&.
  (res <> n + m) |@ "result not sum"

// Generators

let chooseFromList xs = 
  gen {
    let! idx = Gen.choose (0, List.length xs - 1) 
    return (List.nth xs idx)
  }

let primeIsOdd =
  Prop.forAll (Arb.fromGen (chooseFromList [2; 3; 5; 7; 11]))
              (fun p -> p % 2 = 1)

let booleanGen =
  Gen.oneof [
    gen { return true }
    gen { return false }
  ]

let optimist =
  Gen.frequency [
    (2, gen { return true })
    (1, gen { return false })
  ]

let naturalGen = Gen.sized (fun size -> Gen.choose (0, size))

type Tree =
  | Leaf   of int
  | Branch of Tree * Tree

let rec unsafeTreeGen () =
  Gen.oneof [
    Gen.map Leaf
            Arb.generate<int>
    Gen.map2 (fun left right -> Branch (left, right))
             (unsafeTreeGen ())
             (unsafeTreeGen ())
  ]

let treeGen =
  let rec sizedTreeGen size =
    match size with
      | 0 -> Gen.map Leaf Arb.generate<int>
      | _ -> let subtreeGen = sizedTreeGen (size / 2)
             Gen.oneof [
               Gen.map Leaf
                       Arb.generate<int>
               Gen.map2 (fun left right -> Branch (left, right))
                        subtreeGen
                        subtreeGen
             ]
  Gen.sized sizedTreeGen

let rec leaves tree =
  match tree with
    | Leaf   lab           -> [lab]
    | Branch (left, right) -> leaves left @ leaves right

let leavesNotEmpty =
  Prop.forAll (Arb.fromGen treeGen)
              (fun tree -> List.length (leaves tree) > 0)

// Default generators and shrinkers

(*
  Generator–shrinker pairs can be derived in most cases.
*)

type Generators =
  static member Tree () = {
    new Arbitrary<Tree> () with
      override arbitrary.Generator     = treeGen
      override arbitrary.Shrinker tree = Seq.empty
  }

Arb.register<Generators> ()

let leavesNotEmpty' tree = List.length (leaves tree) > 0

let revRevIsOrigTree (xs : list<Tree>) = List.rev(List.rev xs) = xs
