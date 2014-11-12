(*

  ITT8060 -- Advanced Programming 2014
  Department of Computer Science
  Tallinn University of Technology
  ------------------------------------------------

  Coursework 8: Ensuring data properties via types

  ------------------------------------------------
  Name:
  Student ID:
  ------------------------------------------------


  Answer the questions below. You answers to the questions should be correct F#
  code written after the question. This file is an F# script file; it should be
  possible to load the whole file at once. If you can't, then you have
  introduced a syntax error somewhere.

  This coursework will be graded.

  Commit and push your solution to the repository as file coursework8.fsx in
  directory coursework8.

  The deadline for completing the above procedure is Friday, November 21, 2014.

  We will consider the submission to be the latest version of the appropriate
  files in the appropriate directory before the deadline of a particular
  coursework.

*)

(*

   1. The following function is not tail recursive so cannot be used
   on very large lists. Modify it so that it is.

   let rec prod lst =
     match lst with
       | [] -> 1
       | x::xs -> x * prod xs

*)

(*

   2. The following function is not tail recursive so cannot be used
   on very large lists. Modify it so that it is.

   let rec zip lst =
     match lst with
       | [] -> []
       | (x,y)::xs -> x + y :: zip xs

*)

(*

   3. The following noisy function is liable to make the same
   recursive calls multiple times, use memoization to cache the
   results, and prevent unnecessary work.

   let rec f n =
     printfn "calling f %d" n
     if n < 3 then 1 else
     f (n - 1) * f (n - 2)

*)


(*

   4. The following imperative style function modifies its input, fix
      it so that it presents a purely functional interface, whilst
      keeping it's current style internally.

      let g (xs : int []) =
        for i in 0 .. xs.Length-1 do
           xs.[i] <- xs.[i] + 1
        xs
*)

(* 5. The zip function in question 2 is too slow on large inputs,
      change it so that it uses arrays instead of lists. The new
      function should have the following signature:

      zipA : (int * int) [] -> int []

      You may use imperative features inside the
      function but make sure you present a purely functional
      interface.
*)
