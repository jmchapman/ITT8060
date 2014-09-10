// Lecture 2
// =========
// let, tuples, lists + coursework 0 solution
// based on chapter 3 of RWFP


let multiply x y = x * y

let multiply' (x , y) = x * y

// this sequence of lines
let number = 42
printfn "%d" number
let message = "Answer: " + number.ToString()
printfn "%s" message 

// really means this where scoping is more explicit
let number = 42 in
(
  printfn "%d" number;
  let message = "Answer: " + number.ToString() in printfn "%s" message
)

let printSquares message num1 num2 =
  let printSquareUtil num =
    let squared = num * num
    printfn "%s %d: %d" message num squared
  printSquareUtil num1
  printSquareUtil num2

printSquares "Square of" 14 27

// coursework0 solution

// 0. Find your way to the fsharp interactive (fsi) command prompt.
//    I.e. log in to a lab machine and start Visual Studio, install
//    VS/Mono on your laptop, etc.

// 1. Load the following function into fsi

let greeting name = printfn "Hello: %s" name 

// 2. Run the function 'greeting' and say hello to yourself.
//    Type the expression below.

greeting "James"

// 3. Define
//    'splitAtChar : text:string -> sep:char -> list<string>'

let splitAtChar (text: string) (sep:char) = text.Split sep |> Array.toList 

// 4. Modify splitAtSpaces to use splitAtChar

let splitAtSpaces (text: string) = splitAtChar text ' '

// 5. Define 'sentenceCount : text:string -> int

let sentenceCount text = splitAtChar text '.' |> List.length

// 6. Define 'stats : text:string -> unit'
//    which prints the same stats as showWordCount +
//    the number of sentences and average length of sentences
//    hint: try float: 'int -> float'

let wordCount text =
  let words = text |> splitAtSpaces
  let numWords = words.Length
  let wordSet = Set.ofList words
  let numDups = numWords - wordSet.Count
  (numWords, numDups)

let count text =
  let numWords, numDups = wordCount text
  let numSens = sentenceCount text
  let avg = float numWords / float numSens
  numWords , numDups, numSens , avg

let stats text =
  let numWords , numDups , numSens , avg  = count text
  printfn "--> %d words in text" numWords
  printfn "--> %d duplicate words" numDups
  printfn "--> %d sentences in text" numSens
  printfn "--> %f average words per sentence" avg

// 7. Use the 'http' function from the lecture to download the file
//    http://dijkstra.cs.ttu.ee/~juhan/itt8060/text.txt as a string
//    NOTE: you cannot use this function in tryfsharp. Instead you can
//    paste the text into your file as a string and process it locally

open System.IO
open System.Net

// get the contents of the url via a web request
let http (url: string) =
  let req = WebRequest.Create(url)
  let resp = req.GetResponse()
  let stream = resp.GetResponseStream()
  let reader = new StreamReader(stream)
  let html = reader.ReadToEnd()
  resp.Close()
  html

let text = http "http://dijkstra.cs.ttu.ee/~juhan/itt8060/text.txt"

// 8. run 'stats' on the downloaded file

stats text

// (stuff for coursework0)

let splitAtSpaces (text: string) = text.Split ' ' |> Array.toList 

splitAtSpaces "hello world"
splitAtSpaces ""
splitAtSpaces " "
splitAtSpaces "hello  world"

// Analyze a string for duplicate words
let wordCount text =
  let words = text |> splitAtSpaces
  let numWords = words.Length
  let wordSet = Set.ofList words
  let numDups = numWords - wordSet.Count
  (numWords, numDups)

let showWordCount text =
  let numWords , numDups = wordCount text
  printfn "--> %d words in text" numWords
  printfn "--> %d duplicate words" numDups

open System.IO
open System.Net

// get the contents of the url via a web request
let http (url: string) =
  let req = WebRequest.Create(url)
  let resp = req.GetResponse()
  let stream = resp.GetResponseStream()
  let reader = new StreamReader(stream)
  let html = reader.ReadToEnd()
  resp.Close()
  html

// tuples

let tp = "Hello world" , 42

let prague = "Prague", 1188126
let seattle = "Seattle", 594210

let printCity cityInfo =
  printfn "Population of %s is %d" (fst cityInfo) (snd cityInfo)

printCity prague
printCity seattle

let withItem2 newItem2 tuple =
  let originalItem1 , originalItem2 = tuple
  originalItem1, newItem2

let pragueOld  = "Prague", 11188000
let pragueNew  = withItem2 (snd pragueOld + 13195) pragueOld

let withItem2 newItem2 tuple =
  match tuple with
    | originalItem1, _ -> originalItem1, newItem2

let setPopulation tuple newPopulation =
  match tuple with
    | "New York", _ -> "New York", newPopulation + 100
//    | cityName, _ -> cityName, newPopulation

let prague = "Prague", 123
let newyork = "New York", 123

setPopulation prague 10
setPopulation newyork 10

// lists and recursion

let rec factorial n =
  if n <= 1 then
    1
  else
    n * factorial (n - 1)

factorial 5

let ls1 = [] // [] is nil
let ls2 = 5 :: ls1 // :: is called 'cons'
let ls3 = 3 :: 4 :: 5 :: [] // as written on the board
let ls4 = [3;4;5]

let squareFirst list =
  match list with
    | head :: _ -> head * head
    | []        -> -1 // failwith "oops"

let list = [1..5]

let rec sumList list =
  List.map (printf "%d;") list
  printfn ""
  match list with
    | [] -> 0
    | head::tail -> head + sumList tail

sumList [1..5]

let rec prodList list =
  match list with
    | [] -> 1
    | head::tail -> head * prodList tail
prodList [1..5]

// fold
let rec aggregateList (list : int list) (init : int) (op : int -> int -> int) : int =
  match list with
    | [] -> init
    | head :: tail -> op head (aggregateList tail init op)

let sumList list = aggregateList list 0 (+)
sumList [1..5]
let prodList list = aggregateList list 1 (*)
prodList [1..5]
