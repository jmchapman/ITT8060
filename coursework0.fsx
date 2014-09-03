(*

  ITT8060 -- Advanced Programming 2014
  Department of Computer Science
  Tallinn University of Technology
  ------------------------------------

  Coursework 0: Getting started

  ------------------------------------
  Name:
  Student ID:
  ------------------------------------

  Answer the questions below.  You answers to questions 2--8 should be
  correct F# code written after the question. The F# code for question
  1 is written for you and serves as an example. This file is an F#
  script file, it should be possible to load the whole file at
  once. If you can't then you have introduced a syntax error
  somewhere.

  This coursework will not be graded but we encourage you to do it,
  you will not succeed in this course if you don't practice, and
  there's no time like the present! Also, you may find that parts of
  it appear in later courseworks.

*)

// 0. Find your way to the fsharp interactive (fsi) command prompt.
//    I.e. log in to a lab machine and start Visual Studio, install
//    VS/Mono on your laptop, etc.

// 1. Load the following function into fsi

let greeting name = printfn "Hello: %s" name 

// 2. Run the function 'greeting' and say hello to yourself.
//    Type the expression below.

// 3. Define
//    'splitAtChar : text:string -> sep:char -> list<string>'

// 4. Modify splitAtSpaces to use splitAtChar

// 5. Define 'sentenceCount : text:string -> int'

// 6. Define 'stats : text:string -> unit'
//    which prints the same stats as showWordCount +
//    the number of sentences and average length of sentences
//    hint: try float: 'int -> float'

// 7. Use the 'http' function from the lecture to download the file
//    http://dijkstra.cs.ttu.ee/~juhan/itt8060/text.txt as a string
//    NOTE: you cannot use this function in tryfsharp. Instead you can
//    paste the text into your file as a string and process it locally

// 8. run 'stats' on the downloaded file
