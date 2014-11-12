(* lecture 11: based on chapter 10 of RWFP *)

(* optimizations: tail recursion, memoization, imperative features *)

let test1 = [ 1 .. 100000 ]

let rec sum xs =
  match xs with
    | [] -> 0
    | x::xs -> x + sum xs

sum test1

let test2 = [ 1 .. 1000000 ]
    
sum test2

let rec foo arg =
  if (arg = 1000) then true
  else foo (arg + 1)

let rec foo2 arg =
  if (arg = 1000000) then true
  else foo2 (arg + 1)

foo2 1

let sum xs =
  let rec sumUtil xs acc =
    match xs with
      | [] -> acc
      | x::xs -> sumUtil xs (acc + x)
    sumUtil xs 0

sum test1
sum test2

let addSimple (a , b) =
  printfn "adding %d + %d" a b
  a + b

open System.Collections.Generic

let add =
  let cache = new Dictionary<_,_>()
  (fun x ->
   match cache.TryGetValue x with
   | true , v -> v
   | _        -> let v = addSimple x
                 cache.Add(x,v)
                 v)

add(2,3)
add(2,3)
add(3,2)

let memoize f =
  let cache = new Dictionary<_,_>()
  (fun x ->
   match cache.TryGetValue x with
   | true , v -> v
   | _        -> let v = f x
                 cache.Add(x,v)
                 v)

let add = memoize addSimple
add(2,3)

let rec fac x =
  printfn "fac (%d); " x
  if (x <= 0) then 1 else x * fac (x-1)

fac 3
fac 3

let facMem = memoize fac
facMem 3
facMem 3
facMem 4

let rec facMem = memoize (fun x ->
  printfn "fac (%d); " x
  if (x <= 0) then 1 else x * facMem (x-1))

facMem 3
facMem 3
facMem 4

let prepend el list = el :: list

let rec append el list =
  match list with
    | [] -> [el]
    | x::xs -> x :: append el xs
    
#time
let l = [ 1 .. 100000 ]
for i = 1 to 100 do ignore (prepend i l)
for i = 1 to 100 do ignore (append i l)

let a = [| 1 .. 100000 |]
for i = 1 to 100 do ignore (l |> List.map id)
for i = 1 to 100 do ignore (a |> Array.map id)

let arr = [| 1 .. 5 |]
arr.[2] <- 30
arr

let mutable sum = 0
for i in 0 .. arr.Length - 1 do
  sum <- arr.[i] + sum
sum

let rnd = new System.Random()
let numbers = Array.init 5 (fun _ -> rnd.Next(20))

let blurArray (arr:int[]) : int[] =
  let res = Array.create arr.Length 0
  res.[0] <- (arr.[0] + arr.[1]) / 2
  res.[arr.Length-1] <- (arr.[arr.Length - 2] + arr.[arr.Length - 1]) / 2
  for i in 1 .. arr.Length - 2 do
    res.[i] <- (arr.[i-1] + arr.[i] + arr.[i+1]) / 3
  res

blurArray numbers
blurArray numbers
numbers |> blurArray |> blurArray |> blurArray |> blurArray
