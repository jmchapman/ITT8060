

// find duplicate words in a string

// split a string into words at spaces

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
  let numDups = numWords - wordSet.Count in (numWords, numDups)

let numWords , numDups =  wordCount "All the king's horses and all the king's men"

let showWordCount text =
  let numWords , numDups = wordCount text
  (printfn "--> %d words in text" numWords ; printfn "--> %d duplicate words" numDups)

showWordCount "Couldn't put Humpty together again"

// more about let

let powerOfFour n = (n * n) * (n * n) * 1.0
let poewrOfFour' n = (n * n) * (n * n)
powerOfFour 3

let badDefinition1 =
  let words = splitAtSpaces text
  let text = "We three kings"
  word.Length

let badDefinition2 = badDefinition2 + 1

let powerOfFourPlusTwo n =
  let n1 = n * n
  let n2 = n1 * n1
  let n3 = n2 + 2
  n3


// http function required for coursework:

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



