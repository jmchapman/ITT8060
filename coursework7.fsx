(*

  ITT8060 -- Advanced Programming 2014
  Department of Computer Science
  Tallinn University of Technology
  ------------------------------------------------

  Coursework 7: Testing

  ------------------------------------------------
  Name:
  Student ID:
  ------------------------------------------------


  Answer the questions below. You answers to the questions should be correct F#
  code written after the question. This file is an F# script file; it should be
  possible to load the whole file at once. If you can't, then you have
  introduced a syntax error somewhere.

  This coursework will be graded.

  Commit and push your script part of the solution to the repository as
  file coursework7.fsx in directory coursework7.

  The file that should be compiled to a dll should go into coursework7.fs.

  Please do not upload DLL-s. Just include a readme.txt file containing the 
  dependencies required (additional DLLs)

  The deadline for completing the above procedure is Friday, November 14, 2014.

  We will consider the submission to be the latest version of the appropriate
  files in the appropriate directory before the deadline of a particular
  coursework.

*)

(*
     One of your former colleagues wrote some code to convert Roman numbers to Arabic
     numbers. After writing this code he left for greener pastures at a new
     and cool startup.

     You are now left to make sure the code he wrote works and can be shipped to the
     customer, one of the largest banks in the region and the most important one to 
     your company. 
*)

(*   1) You are given the code in file coursework7input/Library1.fs that can be
     compiled to BrokenRomanNumbers.dll.
     You are expected to test the code using NUnit unit tests (at least 5).
*)

(*   2) Given the source code of BadRomanNumbers you should write a script file
     that performs FsCheck tests on the function convert() (at least 3). 
*)

(*   3) List faults discovered as a table. Please try to shrink the inputs
     to the smallest samples corresponding to the appropriate fault.

RomanNumber ExpectedOutput OutputFromConvert FoundWithFsCheckOrNUnit
*)

(*   4) Bonus question
     Write a CorrectRomanNumbers implementation in functional style that you
     would be confident to include in mission critical applications.
*)
