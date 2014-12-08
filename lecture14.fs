// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

open System.Reactive.Linq
let obs1 = Observable.Return(42) // new int[0]
let enu1 = []
let enu2 = [12]
let obs2 = Observable.Empty<int>() // new[] { 42 }
let obs3 = Observable.Never<int>() // stuck iterator
let obs4 = Observable.Throw<int>(new System.Exception()) // throwing iterator
let enu6 : int list = [ raise (new System.Exception("Generic error")) ]
obs1.Subscribe(printfn "%d")
obs2.Subscribe(printfn "%d")
obs3.Subscribe(printfn "%d")
obs4.Subscribe(printfn "%d")

let obs4 = Observable.Range(0,3) // [ 0 .. 3 ]
obs1.Subscribe(printfn "%d")

List.iter (printfn "%d") [ 0 .. 3 ]

let obs5 = Observable.Generate(
  0,
  (fun i -> i < 10),
  (fun i -> i + 1), 
  fun i -> i * i)

obs5.Subscribe(printfn "%d")


let enu5 = List.init 10 (fun i -> i * i)
let enu5' = [ for i in [1..10] do yield i*i ]
List.iter (printfn "%d") enu5


open System
let xs = Observable.Generate(
  0,
  (fun _ -> true),
  (fun i -> i + 1),
  (fun i -> new string('*',i)),
  (fun i -> System.TimeSpan.FromSeconds(float i)))
let sub = xs.Subscribe(printfn "%s")
sub.Dispose()

open System
open System.Drawing
open System.Windows.Forms

let mainForm = new Form(Width = 620, Height = 450, Text = "Browser")
mainForm.MouseMove.Add(fun e -> if e.Location.X = e.Location.Y then printfn "bing!")
// imperative
// hard to remove
let filteredMouse = 
  mainForm.MouseMove 
  |> Observable.filter (fun e -> e.Location.X = e.Location.Y )
  |> Observable.subscribe(fun e -> printfn "bong!")
mainForm.Show()
filteredMouse.Dispose()

//failed example
open System.IO
let fs = File.OpenRead(@"c:\Users\jmcha_000\Desktop\Script1.fsx")
let ofs = Observable.map 
let bs : byte [] = Array.create 1024 (byte 0)

// async downloader
open System.Net
open System.IO

let download(url:string) = async {
    let request = HttpWebRequest.Create(url)
    let! response = request.AsyncGetResponse()
    use response = response
    let stream = response.GetResponseStream()
    use reader = new StreamReader(stream)
    let! text = reader.AsyncReadToEnd()
    return text
}

open System
open System.Drawing
open System.Windows.Forms
open System.Reactive.Linq
open System.Reactive.Concurrency
let newForm = new Form()
let textbox = new TextBox(Width = 200)
let textbox2 = new TextBox(Top = 20, Multiline = true, Height = 200, Width = 200)
newForm.Controls.Add(textbox)
newForm.Controls.Add(textbox2)
let ts = textbox.TextChanged.Throttle(TimeSpan.FromSeconds(1.0))
let sub = ts.ObserveOn(textbox).Subscribe(fun e -> 
  printfn "%s" textbox.Text
  let adown = download textbox.Text
  try 
    textbox2.Text <- Async.RunSynchronously adown
  with
    _ -> textbox2.Text <- "error"
  )
newForm.Show()

sub.Dispose()

// i can convert from enumable to observable, e.g. if i want to test code that uses textchanged, i can make a list inputs
// or mousemove with list of points

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code
