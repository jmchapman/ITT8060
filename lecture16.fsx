// lecture 16

// casting

// down casting
let obj = System.Object()
obj :? string
obj :?> string

// up cast
let str = "hello"
str :> System.Object
str :> System.Object :?> string

// Lazyness

// closures

let x = printfn "bring!"; 3
let x () = printfn "bring!"; 3
x()

let foo n =
  printfn "foo (%d)" n
  n <= 10

  foo 10
  foo 10

let n = lazy (foo 10)
n.Value
n.Value

n.Value && true

let x = Some 10
x.Value

let y = None
y.Value

type InfiniteInts = | Cell of int * InfiniteInts

let rec numbers num = Cell (num, numbers (num + 1))
numbers 10

type InfiniteInts = | LazyCell of int * Lazy<InfiniteInts>

let rec numbers num = LazyCell (num, lazy numbers (num + 1))
numbers 10

let tail (LazyCell (hd, tl)) = tl.Value

numbers 10 |> tail |> tail

let rec numbers num = seq {
  yield num
  yield! numbers (num + 1) }
numbers 10
