// INTERACTIVE TYPE INTERFERENCE

type ``?`` = Dunno

(*
  Dunno can be used as a subexpression to get the type of the expected
  subexpression. Its use will trigger an error message of the form “This
  expression was expected to have type ⟨correct type⟩, but here has type ?”

  For example, enter the following at the F# Interactive prompt:

    Option.bind (fun x -> x) (Some Dunno);;
*)

module BinaryTree =

  // Data type

  type Tree<'lab> =
    | Leaf   of 'lab
    | Branch of Tree<'lab> * Tree<'lab>

  // Computing the list of leaves

  (*
    Version without explicit type annotations, which works:

      let rec leaves tree =
        match tree with
          | Leaf   lab           -> [lab]
          | Branch (left, right) -> leaves left @ leaves right
  *)

  let rec leaves<'lab> (tree : Tree<'lab>) : list<'lab> =
    match tree with
      | Leaf   lab           -> [lab]
      | Branch (left, right) -> leaves left @ leaves right

  // Transforming labels

  let rec map<'srcLab, 'dstLab> (f    : 'srcLab -> 'dstLab)
                                (tree : Tree<'srcLab>)
                                : Tree<'dstLab> =
    match tree with
      | Leaf   lab           -> Leaf   (f lab)
      | Branch (left, right) -> Branch (map f left, map f right)

module PerfectBinaryTree =

  // Data type

  type Tree<'lab> =
    | Simple  of 'lab
    | Complex of Tree<'lab * 'lab>

  (*
    Note the following:

      • The number of leaves is always a power of 2, so not all lists can be
        turned into corresponding perfect binary trees.

      • A list whose length is a power of 2 greater than 2 can be turned into
        several binary trees, but only one perfect binary tree.

      • Balancing is often used to allow for efficient access to elements. There
        are similar data structures that can store an arbitrary number of
        elements, for example:

          – (a, b)-trees (classical search tree structure)

          – finger trees (used, for example, to implement sequences in the
            Haskell collections library)
  *)

  // Example trees

  let example1 = Simple  1
  let example2 = Complex (Simple (1, 2))
  let example3 = Complex (Complex (Simple ((1, 2), (3, 4))))
  let example4 = Complex (Complex (Complex (Simple (((1, 2), (3, 4)),
                                                    ((5, 6), (7, 8))))))

  // Computing the list of leaves

  (*
    Version without explicit type annotations, which does not work:

      let rec leaves tree =
        match tree with
          | Simple  lab   -> [lab]
          | Complex tree' -> let pairToList (lab1, lab2) = [lab1; lab2]
                             leaves tree' |> List.collect pairToList
  *)

  let rec leaves<'lab> (tree : Tree<'lab>) : list<'lab> =
    match tree with
      | Simple  lab   -> [lab]
      | Complex tree' -> let pairToList (lab1, lab2) = [lab1; lab2]
                         leaves<'lab * 'lab> tree' |> List.collect pairToList
                           // annotation not needed in the last line

  // Transforming labels

  let rec map<'srcLab, 'dstLab> (f    : 'srcLab -> 'dstLab)
                                (tree : Tree<'srcLab>)
                                : Tree<'dstLab> =
    match tree with
      | Simple  lab   -> Simple  (f lab)
      | Complex tree' -> let f' (lab1, lab2) = f lab1, f lab2
                         Complex (map f' tree')
