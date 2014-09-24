(*

  ITT8060 -- Advanced Programming 2014
  Department of Computer Science
  Tallinn University of Technology
  ------------------------------------
  Lecture 4: interoperability of F# and .NET libraries

  James Chapman, Juhan Ernits, Wolfgang Jeltsch

  Material based on chapter 4 of RWFP

*)


//F#'s relation to C# (Don Syme's examples)

//F#
open System
let a = 2
Console.WriteLine(a)

////C#
//using System;
//
//namespace ConsoleApplication1;
//{
//  class Program
//  {
//    static int a()
//    {
//       return 2;
//    }
//    static void Main(string[] args)
//    {
//       Console.WriteLine(a);
//    }
//  }
//}

open System

let data = "Test data,1234"

let convertDataRow(csvLine:string) = 
   let cells = List.ofSeq(csvLine.Split(','))
   match cells with
   | title :: number :: _ -> 
      let parsedNumber = Int32.Parse(number)
      (title,parsedNumber)
   | _ -> failwith "Incorrect data format!"

let x1 = Int32.Parse("a")
let x2 = Int32.TryParse("a")
let x3 = ref 3
let res = Int32.TryParse("4",x3)
x3.Value
let mutable x4 = 4
x4 <- 5

convertDataRow(data)

String.Concat("first part", "second part")

String.Concat("a","b","c","d","e")
String.Concat([|"a";"b";"c";"d";"e"|])

String.Join(",","a","b")

String.concat "," ["a";"b"]

let anArray = [|"a";"b"|]

let rec processLines(lines) =
  match lines with
  | [] -> []
  | currentLine :: remaining ->
    let parsedLine = convertDataRow(currentLine)
    let parsedRest = processLines(remaining)
    parsedLine :: parsedRest

open System.IO

let lines = List.ofSeq(File.ReadAllLines(@"d:\tmp\data.csv"))

let rec calculateSum (rows) =
  match rows with
  | [] -> 0
  | (_,value) :: tail ->
    let remainingSum = calculateSum(tail)
    value + remainingSum 

calculateSum (processLines (lines))

let i1 = 1234

let i2 = 1234u

let i3 = 1234L

let f1 = 3.14

let f2 = 3.14f

let b1 = 127y

let b2 = 127uy

let b3 = b1 + 1y

let i4 = 3 + int(1y)

let bigint = 1I

let (succ,num) = Int32.TryParse("a")
if succ then Console.Write("Succeeded: {0}", num)
else Console.Write("Failed!")


open System
open System.Drawing

let rnd = new Random()

rnd.Next()

let randomBrush() =
  let r, g, b = rnd.Next(256), rnd.Next(256), rnd.Next(256)
  new SolidBrush(Color.FromArgb(r,g,b))

let fnt = new Font("Verdana", 11.0f)

let centerX, centerY  = 300.0, 200.0
let labelDistance = 150.0

let drawLabel(gr:Graphics, title, startAngle, angle) = 
  let lblAngle = float (startAngle + angle / 2)
  let ra = Math.PI * 2.0 * lblAngle / 360.0
  let x = centerX + labelDistance * cos(ra)
  let y = centerY + labelDistance * sin(ra)
  let size = gr.MeasureString(title,fnt)
  let rc = new PointF(float32(x) - size.Width / 2.0f,
                      float32(y) - size.Height / 2.0f)
  gr.DrawString(title,fnt,Brushes.Black,new RectangleF(rc, size))



let drawPieSegment(gr:Graphics, title, startAngle,occupiedAngle) = 
  let br = randomBrush()
  gr.FillPie (br , 170, 70, 260, 260, startAngle, occupiedAngle)
  br.Dispose()

let drawStep (drawingFunc, gr:Graphics, sum, data) = 
  let rec drawStepUtil (data, angleSoFar) = 
    match data with
    | [] -> ()
    | [title, value] -> 
      let angle = 360 - angleSoFar
      drawingFunc(gr, title, angleSoFar, angle)
    | (title, value) :: tail -> 
      let angle = int (float(value) / sum * 360.0)
      drawingFunc(gr,title, angleSoFar,angle)
      drawStepUtil(tail,angleSoFar + angle)
  drawStepUtil(data,0)

let drawChart(file) =
  let lines = List.ofSeq (File.ReadAllLines(file))
  let data = processLines(lines)
  let sum = float (calculateSum(data))

  let pieChart = new Bitmap(600, 400)
  let gr = Graphics.FromImage(pieChart)
  gr.Clear(Color.White)
  drawStep(drawPieSegment, gr, sum, data)
  drawStep(drawLabel, gr, sum, data)

  gr.Dispose()
  pieChart

let pieChart = drawChart(@"d:\tmp\data.csv")
pieChart.Save(@"d:\tmp.png")