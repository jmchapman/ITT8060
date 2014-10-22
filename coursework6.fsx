(*

  ITT8060 -- Advanced Programming 2014
  Department of Computer Science
  Tallinn University of Technology
  ------------------------------------------------

  Coursework 6: Ensuring data properties via types

  ------------------------------------------------
  Name:
  Student ID:
  ------------------------------------------------


  Answer the questions below. You answers to the questions should be correct F#
  code written after the question. This file is an F# script file; it should be
  possible to load the whole file at once. If you can't, then you have
  introduced a syntax error somewhere.

  This coursework will be graded.

  Commit and push your solution to the repository as file coursework6.fsx in
  directory coursework6.

  The deadline for completing the above procedure is Friday, October 31, 2014.

  We will consider the submission to be the latest version of the appropriate
  files in the appropriate directory before the deadline of a particular
  coursework.

*)

(*
  1. Take the following small module for arbitrary binary trees and extend it
     with a function mirror : Tree<'lab> -> Tree<'lab> that takes a binary tree
     and mirrors it along the vertical axis.
*)

module BinaryTree =

  type Tree<'lab> =
    | Leaf   of 'lab
    | Branch of Tree<'lab> * Tree<'lab>

(*
  2. Take the following small module for perfect binary trees and extend it with
     the following:

       a) a function mirror : Tree<'lab> -> Tree<'lab> that takes a perfect
          binary tree and mirrors it along the vertical axis

       b) a function toBinary : Tree<'lab> -> BinaryTree.Tree<'lab> that takes a
          perfect binary tree and converts it into an ordinary binary tree as
          defined in the lecture
*)

module PerfectBinaryTree =

  type Tree<'lab> =
    | Simple  of 'lab
    | Complex of Tree<'lab * 'lab>

(*
  3. Implement a module PerfectBinaryTernaryTree that contains the following:

       a) a type Tree that works like the above type for perfect binary trees,
          except that a node may have two or three children

       b) a function leaves : Tree<'lab> -> list<'lab> that computes the list of
          leaves of a given tree

       c) a function mirror : Tree<'lab> -> Tree<'lab> that mirrors a given tree
          along the vertical axis
*)
