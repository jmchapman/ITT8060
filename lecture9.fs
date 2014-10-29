(*

   Lecture Oct 29, 2014: Combining behaviour with data.
   Unit testing with FsUnit and NUnit.

   Based on chapter 9 of RWFP.
   The unit testing part is in chapter 11, but the code 
   here has been updated to support FsUnit.

   NB! Initial version. Code will be added during the lecture!
   
*)
module Lecture9.Tests

open System

type Rect =
  {Left   : float32
   Top    : float32
   Width  : float32
   Height : float32}

  member this.Deflate(wspace,hspace) =
    {Left = this.Left + wspace
     Top = this.Top + hspace
     Width = this.Width - (2.0f * wspace)
     Height = this.Height - (2.0f * hspace)}
  
  member this.Area() =
    this.Width * this.Height

let r =  {Left=0.0f; Top=0.0f; Width=100.0f; Height=200.0f}

open System

type Schedule =
  | Never
  | Once of DateTime

let futureOrMaxValue(dt) = 
  if (dt > DateTime.Now) then dt else DateTime.MaxValue

let getNextOccurrence(schedule) =
  match schedule with
  | Never -> DateTime.MaxValue
  | Once(eventDate) -> futureOrMaxValue(eventDate)
  
type Schedule with
  member this.GetNextOccurrence() = getNextOccurrence(this)
  member this.OccursNextWeek = 
    getNextOccurrence(this) < DateTime.Now.AddDays(7.0) 

type Client =
  {Name: string
   Income: int
   YearsInJob: int
   CriminalRecord: bool}

// Defining interfaces
type IClientCredit = 
  abstract Check : Client -> bool
  abstract Report : Client -> unit

// Object expressions
let testCriminal = 
  { new IClientCredit with
      member this.Check(cl) = cl.CriminalRecord = true
      member this.Report(cl) = printfn "'%s' has a criminal record." cl.Name
  }

let testIncome = 
  { new IClientCredit with
      member this.Check(cl) = cl.Income < 1500
      member this.Report(cl) = printfn "The income of '%s' is less than 1500 EUR per month" cl.Name
  }

// Concrete object types
type ClientInfo(name, income,years) = 
  let loanCoefficient = income / 500 * years
  do printfn "Creating client '%s'" name
  
  member x.Name = name
  member x.Income = income
  member x.Years = years
  
  member x.Report() = 
    printfn "Client: %s, loan coefficient: %d" name loanCoefficient 


type Triangle(a:float,b:float,c:float) =
  
  member this.A = a
  member this.B = b
  member this.C = c
  
  member this.IsRightAngled = 
    a*a+b*b=c*c

  member this.IsTriangle =
    a+b > c


//[<EntryPoint>]
//let main argv = 
//    printfn "%A" argv
//    0 // return an integer exit code
