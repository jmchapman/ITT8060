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

// caching photo browser

open System.IO
open System.Drawing
type ImageInfo = {Name: string; Preview : Lazy<Bitmap>}
let dir = @"C:\board"
let createLazyResized file = 
    lazy (printfn "doing stuff!"
          use bmp = Bitmap.FromFile file
          let resized = new Bitmap(400,300)
          use gr = Graphics.FromImage(resized)
          let dst = Rectangle(0,0,400,300)
          let src = Rectangle(0,0,bmp.Width,bmp.Height)
          gr.InterpolationMode <- Drawing2D.InterpolationMode.High
          gr.DrawImage(bmp, dst, src, GraphicsUnit.Pixel)
          resized)

let files = 
  Directory.GetFiles(dir, "*.jpg") |> Array.map (fun file -> 
    { Name = Path.GetFileName file
      Preview = createLazyResized file }             )

open System
open System.Windows.Forms

let main = new Form (Text="Photos", ClientSize= Size(600,300))
let pict = new PictureBox (Dock=DockStyle.Fill)
let list = new ListBox(Dock=DockStyle.Left, Width = 200, DataSource=files,DisplayMember="Name")
list.SelectedIndexChanged.Add(fun _ -> 
  let info = files.[list.SelectedIndex]
  pict.Image <- info.Preview.Value)
main.Controls.Add pict
main.Controls.Add list

main.Show()
