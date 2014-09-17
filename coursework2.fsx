(*

  ITT8060 -- Advanced Programming 2014
  Department of Computer Science
  Tallinn University of Technology
  ------------------------------------

  Coursework 2: Types

  ------------------------------------
  Name:
  Student ID:
  ------------------------------------


  Answer the questions below. You answers to the questions should be
  correct F# code written after the question. This file is an F# script
  file; it should be possible to load the whole file at once. If you
  can't, then you have introduced a syntax error somewhere.

  This coursework will be graded.

  To submit the coursework you will be asked to do the following:
  
    1. Use the Git repository created for coursework 1 at
       http://git.ttu.ee/.

    2. Upload your solution to the repository as file coursework2.fsx in
       directory coursework2.

    3. Create a course user for your repository using the public SSH key
       provided at

         https://git.ttu.ee/courses/itt8060
         
       and give this user read access to your repository.

    4. Submit the repository URL to https://git.ttu.ee/courses/itt8060.
  
  The deadline for completing the above procedure is Friday,
  September 26, 2014.

  Please note that after submitting the repository URL to the course,
  all further homework submissions will require creating a new directory
  in the existing repository, adding the appropriate files to it, and
  committing and pushing them. We will consider the submission to be the
  latest version of the appropriate files in the appropriate directory
  before the deadline of a particular coursework. 

*)

// 1. Write a function rotate : int * char * float -> float * int * char. 
//    Include type annotations for all arguments and the return type of
//    this function, so that it has exactly the above type. Note that F#
//    prints the arguments names as well. This is okay.

// 2. Write a function optionalCode : char option -> int option that
//    converts and optional character to an optional integer, which is
//    its character code.

// 3. Extend the Schedule type such that it contains an optional latest
//    occurrence time for recurring events. For example, a schedule for
//    the lectures of our course would use a latest occurrence of
//    December 23, 2014 to let the lectures end before Christmas.

// 4. Modify getNextOccurences to work with the new Schedule type.

// 5. Consider the following definition of trees whose inner nodes can
//    have two or three children and whose leaves are labelled with
//    integers:
//
//      type Tree =
//        | Leaf      of int
//        | TwoNode   of Tree * Tree
//        | ThreeNode of Tree * Tree * Tree
//
//    Define the value exampleTree : Tree that represents the following
//    tree:
//
//        *
//       / \
//      2   *
//        / | \
//       3  5  7

// 6. Define a function sumTree : Tree -> int that computes the sum of
//    all labels in the given tree.

// 7. Define a function productTree : Tree -> int that computes the
//    product of all labels in the given tree. If this function
//    encounters a label 0, it shall not look at any further labels, but
//    return 0 right away.

// ** Bonus questions **

// 8. Define a function mapTree : (int -> int) -> Tree -> Tree that
//    applies the given function to every label of the given tree.

// 9. Use mapTree to implement a function negateAll : Tree -> Tree that
//    negates all labels of a given tree.
