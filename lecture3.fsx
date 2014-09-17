// Multiple arguments and multiple results

let pair = 11, "Hello!"

let divRem (n, m) = n / m, n % m

let divRem' n m = n / m, n % m

open System

Int32.TryParse "11"
Int32.TryParse "eleven"

let triple       = 11, "Hello!", 'A'
let leftLeaning  = (11, "Hello!"), 'A'
let rightLeaning = 11, ("Hello!", 'A')

let printPlaceInfo name (latitude, longitude) =
  printfn "%s @ (%f°, %f°)" name latitude longitude

let tut = "Tallinn University of Technology", (59.3950, 24.6719)

let tutName, tutPos = tut
printPlaceInfo tutName tutPos

// User-defined data types

type Schedule =
  | Never
  | Once       of DateTime
  | Repeatedly of DateTime * TimeSpan

let tomorrow = DateTime.Now.AddDays(1.0)
let noon     = new DateTime(2014, 9, 17, 12, 0, 0)
let daySpan  = new TimeSpan(24, 0, 0)

let schedule1 = Never
let schedule2 = Once tomorrow
let schedule3 = Repeatedly (noon, daySpan)

let getNextOccurrence schedule =
  match schedule with
    | Never
        -> DateTime.MaxValue
    | Once eventTime
        -> if eventTime > DateTime.Now
             then eventTime
             else DateTime.MaxValue
    | Repeatedly (startTime, interval)
        -> let fromStart = (DateTime.Now - startTime).TotalSeconds
           let cycle     = Math.Floor(fromStart / interval.TotalSeconds) + 1.0
           let cycle     = max cycle 0.0
           startTime.AddSeconds(interval.TotalSeconds * cycle)

let next1 = getNextOccurrence schedule1
let next2 = getNextOccurrence schedule2
let next3 = getNextOccurrence schedule3

// Recursive data types

type IntList =
  | Empty
  | NonEmpty of int * IntList

let rec sumIntList list =
  match list with
    | Empty                 -> 0
    | NonEmpty (head, tail) -> head + sumIntList tail

let rec mapIntList (trans : int -> int) list =
  match list with
    | Empty                 -> Empty
    | NonEmpty (head, tail) -> NonEmpty (trans head, mapIntList trans tail)

let rec filterIntList (prop : int -> bool) list =
  match list with
    | Empty                 -> Empty
    | NonEmpty (head, tail) -> let filteredTail = filterIntList prop tail
                               if prop head
                                   then NonEmpty (head, filteredTail)
                                   else filteredTail

type Tree =
  | Leaf of int
  | Node of Tree * Tree

let tree1 = Leaf 2
let tree2 = Node (Leaf 3, Leaf 5)
let tree3 = Node (tree1, tree2)

let rec sumTree tree =
  match tree with
    | Leaf label         -> label
    | Node (left, right) -> sumTree left + sumTree right

// Optional values

(*
  Remember:

    Int32.TryParse "11" : bool * int
*)

type IntOption =
  | SomeInt of int
  | NoneInt

let none = NoneInt
let two  = SomeInt 2

let fromPair (isCorrect, value) =
  if isCorrect
    then SomeInt value
    else NoneInt

let readInput () =
  let input = Console.ReadLine()
  fromPair (Int32.TryParse input)

(*
  Built-in type optional with data constructors Some and None.
*)
