

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



