(*

  ITT8060 -- Advanced Programming 2014
  Department of Computer Science
  Tallinn University of Technology
  ------------------------------------

  Bonus coursework A: filesystem

  ------------------------------------
  Name:
  Student ID:
  ------------------------------------


  Answer the questions below.  You answers to questions 1--4 should be
  correct F# code written after the question. This file is an F#
  script file, it should be possible to load the whole file at
  once. If you can't then you have introduced a syntax error
  somewhere.

  This coursework is optional but you can get extra bonus marks.
  Please submit it as bonusA/bonusA.fsx in the Git system at git.ttu.ee.
  
  The deadline for completing the above procedure is Friday, October 24, 2014.

*)

// We will make use of the following generic tree type, Nodes can have
// an arbitrary number of children. the type 'a is meant for
// names/labels and the type 'b is meant for data.

type Tree <'a,'b> = Node of list<'a * Tree<'a,'b>>
                  | Leaf of 'b

// One can represent a filesystem to be an instance of this type where
// the file/directory names are given by strings ('a = string) and the
// file contents are also given by strings ('b = string). Directories
// are modelled as nodes. Files are modelled as leaves.

type FileSystem = Tree<string,string>

// Question 1:
// make a filesystem which has the following structure:

// / (d)
// /home (d)
// /usr  (d)
// /usr/bin (d)
// /usr/bin/bash (f)
// /usr/bin/emacs (f)
// /home/.emacs (f)
// /home/.ssh (d)
// /home/.ssh/id_rsa (f)

// Question 2:
// implement the 'ls' command, it should have the following type and behaviour:
//
// ls : FileSystem -> list<string>
// 
// returns a list of entities in the top level directory (not recursive).
// (fail if the filesystem is just a file)

// Question 3:
// Implement a command 'subfs' which extracts the 'sub'
// filesystem at the position given by a path (represented as a list
// of directory names.
//
// subfs : FileSystem -> list<string> -> FileSystem
//
// the first arg is the filesystem, the second arg is a path, return
// the filesystem you find at that path

// Question 4:
// Use your answer to 2 and 3 to list 'contents' of the directory
// given by the path (fail if its just a file). This is an improved
// version of the 'ls' command.
//
// ls' : FileSystem -> list<string> -> list<string>


// Question 5 (tricky!)
// Implement the generic map operation for the Tree type. As there are
// two type variables it should take to functions, hence the name.
// 
// bimap : ('a -> 'c) -> ('b -> 'd) -> Tree<'a,'b> -> Tree<'c,'d>


// Question 6
// Use 'bimap' to change all file and directory names to lower case.

// Question 7 (very tricky!)
// implement filter : ('a -> bool) -> Tree<'a,'b> -> Tree<'a,'b>

// Question 8
// Use 'filter' to filter out hidden files or directories (those whose names
// begin with '.')
