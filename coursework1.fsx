(*

  ITT8060 -- Advanced Programming 2014
  Department of Computer Science
  Tallinn University of Technology
  ------------------------------------

  Coursework 1: Basic operations on lists

  ------------------------------------
  Name:
  TUT Student ID:
  ------------------------------------


  Answer the questions below.  You answers to questions 1--9 should be
  correct F# code written after the question. This file is an F#
  script file, it should be possible to load the whole file at
  once. If you can't then you have introduced a syntax error
  somewhere.

  This coursework will be graded.

  To submit the coursework you will be asked to
  
  1) Create a private GIT repository at http://git.ttu.ee,
  2) Add your solution to the repository, upload the coursework to the 
  repository as coursework1.fsx in directory coursework1
  3) Add the course user with public ssh key provided at
  https://git.ttu.ee/courses/itt8060 to your repository.
  4) Submit the repository URL to https://git.ttu.ee/courses/itt8060
  
  The http://git.ttu.ee will be available for submissions from September 15, 2014.

  The deadline for completing the above procedure is Friday, September 19, 2014.

  Please note that after submitting the repository URL, all further
  homework submissions will require creating a new direcory in the existing repository,
  adding the appropriate files to it, and then, commiting and pushing them.
  We will consider the submission to be the latest version of the appropriate file(s) in the
  appropriate directory before the deadline of a particular coursework. 

*)

// 1. Make an empty list of generic type.

// 2. Make an empty list of type 'char list' (or list<char>).

// 3. Make a three element list called 'news' containing pairs of news
// site url (string) and year of establishment (int). The year of
// establishement can be of the paper or organization not of the
// website.

// 4. Write a function 'filterOutYoungerThan' to filter out news sources
// which are less than 50 years old.  It should use the List.filter
// function from the library.

// 5. Test the function 'filterOutYoungerThan' on your list 'news'.

// 6. Calculuate the average age of your list of news sites. The
// function should use pattern matching and recursion.

// 7. Using the http function write a function
//
//    getSource : (string * int) -> (string * string)
//
//    which takes a pair of a url and a year of establishment and
//    returns a pair of a url and the html source of the page.

// 8. Write a function
//
//    getSize : (string * string) -> (string * int)
//    
//    which takes a pair of a url and its html source and returns a
//    pair of the url and the size of the html (length of the string).


// 9. Write a function
//
//    getSourceSizes : (string * int) list -> (string * int) list
//
//    It should take a list of pairs of urls and years of
//    establishment and return a list of pairs of urls and
//    corresponding html source sizes
