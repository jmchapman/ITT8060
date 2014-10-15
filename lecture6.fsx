// lecture 6

// functions on the board

// options: map and bind
open System

let readInput() =
  let input = Console.ReadLine()
  match Int32.TryParse input with
    | true , i -> Some i
    | false , _ -> None

let map f opt =
  match opt with
    | None -> None
    | Some v -> Some (f v)

let bind f opt =
  match opt with
    | None -> None
    | Some v -> f v

let readAndAdd1() =
  match readInput() with
    | None -> None
    | Some v ->
      match readInput() with
      | None -> None
      | Some w -> Some (v + w)

let readAndAdd2() =
  match readInput() with
    | None -> None
    | Some v -> readInput() |> map (fun w -> w + v)

let readAndAdd3() =
  readInput() |> bind (fun v -> readInput() |> map (fun w -> w + v))

let rec sum xs =
  match xs with
    | [] -> 0
    | x::xs -> x + sum xs

sum [1;2;3]
