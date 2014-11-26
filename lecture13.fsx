// lecture 13
// based on chapter 12 of RWFP
// infinite sequences, duality, monads, computation expressions

Seq.unfold

let nums = Seq.unfold (fun num -> Some (string num , num + 1)) 0

//Seq.toList

nums |> Seq.take 10 |> Seq.toList

let nums2 = seq { let n = 10
                  yield n + 1
                  printfn "second..."
                  yield n + 2 }

nums2 |> Seq.toList
nums2 |> Seq.take 1 |> Seq.toList
nums2 |> Seq.take 2
nums2 |> Seq.take 2 |> Seq.toList

let capitals = [ "Paris"; "Prague" ]
let withNew name = seq { yield name
                         yield "New " + name }
withNew "York"

let allCities = seq { yield "Oslo"
                      yield! capitals
                      yield! withNew "York" }
Seq.toList allCities

let rec factorialsUtil (num, factorial) =
  seq { yield sprintf "%d! = %d" num factorial
        let num = num + 1
        yield! factorialsUtil (num , factorial * num) }
let factorials = factorialsUtil (0,1)

factorials |> Seq.take 10 |> Seq.toList

let cities = [ yield "Oslo"; yield! capitals ]
let cities = [| yield "Oslo"; yield! capitals |]

open System.Drawing
open System
let rnd = new Random()
let rec randomColors = seq {
  let r , g , b = rnd.Next 256, rnd.Next 256 , rnd.Next 256
  yield Color.FromArgb(r , g , b)
  yield! randomColors
  }

let dataSource = [ 490; 495; 450 ]

let coloredSequence = Seq.zip dataSource randomColors
let coloredData = coloredSequence |> List.ofSeq

let nums = [ 1 .. 30 ]
let nums1 = seq { for n in nums do if (n%3 = 0) then yield n * n }
nums1 |> Seq.toList

let cities = [ "New York" , "USA"; "London", "UK" ; "Cambridge", "UK"; "Cambridge", "USA" ]
let entered = ["London" ; "Cambridge" ]

seq { for name in entered do
        for (n , c) in cities do
          if (n = name) then
            yield sprintf "%s (%s)" n c }

entered |> Seq.collect (fun name ->
                        seq { for (n , c) in cities do
                                if (n = name) then
                                  yield sprintf "%s (%s)" n c })

entered |> Seq.collect (fun name ->
                        cities |> Seq.collect (fun (n , c) ->
                                               if (n = name) then
                                                 [ sprintf "%s (%s)" n c ]
                                               else []))
                                                 

open System
let readInput() =
  let input = Console.ReadLine()
  match Int32.TryParse input with
    | true, i -> Some i
    | false, _ -> None
// cannot run this yet
option {
  let! n = readInput()
  let! m = readInput()
  return n * m
}

type OptionBuilder() =
  member x.Bind(opt, f) = Option.bind f opt
  member x.Return v = Some v

let option = new OptionBuilder()

// can run now
option {
  let! n = readInput()
  let! m = readInput()
  return n * m
}

// the above gets translated to
option.Bind (readInput(), fun n -> option.Bind(readInput(), fun m -> option.Return (n * m)))

type Logging<'T> = Log of 'T * list<string>


// writer monad
type LoggingBuilder() =
  member x.Bind(Log(value , logs1) , f) =
    let (Log (newValue, logs2)) = f value
    Log (newValue, logs1 @ logs2)
  member x.Return value = Log(value, [])
  member x.Zero() = Log((), [])

let log = new LoggingBuilder()

let logMessage s =
  Log ((), [s])

let write s = log {
  do! logMessage ("writing: " + s)
  Console.Write s }

let read() = log {
  do! logMessage "reading"
  return Console.ReadLine()
  }

let testIt() = log {
  do! logMessage "starting"
  do! write "Enter name: "
  let! name = read()
  return "Hello " + name + "!"
}

let res = testIt()
let (Log (msg, logs)) = res

let read() = log {
  do! logMessage "reading"
  return Console.ReadLine()
  }

let read() = log.Bind(logMessage "reading", fun () -> log.Return(Console.ReadLine()))

type Exp = | Val of int | Add of Exp * Exp | Var of char

let rec lookup (x : char)(e : list<char * int>) : int =
  match e with
    | [] -> -1
    | (y,i)::xs -> if (x = y) then i else lookup x xs

let rec eval (t : Exp)(e : list<char * int>) : int =
  match t with
  | Val i -> i
  | Add (t, t') -> eval t e + eval t' e
  | Var x -> lookup x e

eval (Val 2) []
eval (Var 'c') ['c',2]
eval (Add (Val 2,Var 'c')) ['c',2]

type EnvBuilder() =
  member x.Bind(m : 'e -> 's, k : 's -> ('e -> 't)) : 'e -> 't = fun e -> k (m e) e
  member x.Return (m : 't) : 'e -> 't = fun _ -> m

let env = new EnvBuilder()

let rec eval (t : Exp)(e : list<char * int>) : int =
  match t with
  | Val i -> i
  | Add (t, t') -> eval t e + eval t' e
  | Var x -> lookup x e

// we can now hide the environment
let rec eval (t : Exp) : list<char * int> -> int = env {
  match t with
    | Val i -> return i
    | Add (t , t') -> let! x = eval t
                      let! y = eval t'
                      return x + y
    | Var c -> let! x = lookup c
               return x
  
  }

eval (Val 2) []
eval (Var 'c') ['c',2]
eval (Add (Val 2,Var 'c')) ['c',2]

