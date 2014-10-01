(* Lecture 5 ITT8060

   Generics, higher order functions, deeper into functions, option, map etc.

   No new compulsory coursework today!

   *Bonus* coursework out today for those who are interested/like a challenge.

*)

// .Net syntax
type Option<'a> = Some of 'a | None

// OCaml syntax
type 'a Option = Some of 'a | None

open System

let readInput() =
  let input = Console.ReadLine()
  match Int32.TryParse input with
    | true, i -> Some i
    | false, _ -> None

// type inference
let num = 123
let tup = (123, "hello")
Some 1
Some 'a'
None

let input =
  printfn "Calculating..."
  if (num = 0) then None else Some (num.ToString())

let readValue (opt : 'a option) : 'a =
  match opt with
    | Some n -> n
    | None   -> failwith "No value"

// function values
let nums = [ 4; 9; 1; 8; 6 ]

let eventest n = (n % 2 = 0)
let evens = List.filter eventest  nums

let square1 (a : int) : int = a * a
let square2 : int -> int = fun a -> a * a

square1 2
square2 2

let add : int -> int -> int = fun a b -> a + b

let twice input f = f (f input)

// disfunctional style
let add = fun (a , b) -> a + b
// add (10,_)
// functional
let add = fun a b -> a + b
// which means
let add = fun a -> fun b -> a + b

add 10
let addTen = add 10

List.map addTen [ 1 .. 10 ]
List.map (add 10) [ 1 .. 10 ]

// on to chapter 6
// can use characters +/-*<>&|=$%.?@~!
let (+>) a b = a + "\n>> " + b

printfn ">> %s" ("Hello world" +> "How are you?" +> "I'm fine!")

let (|>) x f = f x

List.head(List.rev [ 1 .. 5 ])
[ 1 .. 5 ] |> List.rev |> List.head
// C# a bit like list.Reverse().Head()

// tuples
let oldPrague = "Prague", 123

// first attempt
let name, pop = oldPrague
let newPrague = name , pop + 1

// second attempt
let newPrague = fst oldPrague , snd oldPrague + 1


// third attemp
let newPrague = oldPrague |> mapSecond ((+) 1)

//let mapSecond f (a , b) = a , f b
//let mapFirst f (a , b) = f a , b
let bimap f g (a , b) = f a , g b
let mapFirst f p = bimap f id p

let id x = x

open System

type Schedule<'a> =
  | Never
  | Once of DateTime
  | Repeatedly of DateTime * TimeSpan

(fun d -> d.AddDays(7.0)) (DateTime(2008,1,1))
// pipeline fix
(DateTime(2008,1,1)) |> fun d -> d.AddDays(7.0)
// annotation fix
(fun (d : DateTime) -> d.AddDays(7.0)) (DateTime(2008,1,1))
((fun d -> d.AddDays(7.0)) : DateTime -> DateTime) (DateTime(2008,1,1))

// why are you using a lambda anyway?
(DateTime(2008,1,1)).AddDays(7.0)

let mapSched (f : DateTime -> DateTime) (sched : Schedule) : Schedule =
  match sched with
    | Never -> Never
    | Once dt -> Once (f dt)
    | Repeatedly (dt, ts) -> Repeatedly (f dt, ts)

mapSched (fun d -> d.AddDays (7.0)) (Once (DateTime(2008,1,1)))



let scheds = [ Never; Once(DateTime(2008,1,1)) ]

List.map (mapSched (fun d -> d.AddDays(7.0))) scheds

// map, bind

let readInput() =
  let input = Console.ReadLine()
  match Int32.TryParse input with
    | true, i -> Some i
    | false, _ -> None

let readAndAdd1() =
  match readInput() with
  | None -> None
  | Some n ->
    readInput() |> Option.map ((+) n)

let map f opt =
  match opt with
    | None -> None
    | Some x -> Some (f x)

let bind f opt =
  match opt with
    | None -> None
    | Some x -> f x

let readAndAdd2() = readInput() |> bind (fun n -> readInput() |> Option.map ((+) n))
