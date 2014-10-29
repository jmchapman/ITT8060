
(*

   Lecture Oct 29, 2014: Combining behaviour with data.
   Unit testing with FsUnit and NUnit.

   Based on chapter 9 of RWFP.
   The unit testing part is in chapter 11, but the code 
   here has been updated to support FsUnit and NUnit.

If tests fail to run in Visual studio/Windows (FsUnit dll related error messages) then check that
your Help -> About Visual Studio shows that you have installed update 3 to VS2013 and appropriate 
.Net framework updates.

E.g. 

Microsoft Visual Studio Ultimate 2013
Version 12.0.30723.00 Update 3
Microsoft .NET Framework
Version 4.5.51641

If that does not work, you can create an application configuration file manually.

In MonoDevelop it is possible to get FsUnit with NUnit to work
by adding application configuration file:

Add -> New File -> Misc -> Application configuration file

You should put the following XML into the contents of the applicatin configuration file:

<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <runtime>
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      <dependentAssembly>
        <assemblyIdentity name="FSharp.Core" publicKeyToken="b03f5f7f11d50a3a" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-4.3.0.0" newVersion="4.3.0.0" />
      </dependentAssembly>
    </assemblyBinding>
  </runtime>
</configuration>

After completing the above, the below code works
in Linux using MonoDevelop (adding dependencies using
NuGet required installing NUnit manually before FsUnit).

*)



open System

type Rect =
  {Left   : float32
   Top    : float32
   Width  : float32
   Height : float32}

  member this.Deflate(vspace,hspace) =
    {Left = this.Left + vspace
     Top = this.Top + hspace
     Width = this.Width - (2.0f * vspace)
     Height = this.Height - (2.0f * hspace)}
  
  member this.Area() =
    this.Width * this.Height

let r =  {Left=0.0f; Top=0.0f; Width=100.0f; Height=200.0f}
r.Area()

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

#if INTERACTIVE
#r @"..\packages\NUnit.2.6.3\lib\nunit.framework.dll"
#r @"..\packages\FsUnit.1.3.0.1\Lib\Net40\FsUnit.NUnit.dll"
#endif

open NUnit.Framework
open FsUnit

[<TestFixture>]
type ``Given a rightangled triangle`` () =
  let triangle = new Triangle(3.0,4.0,5.0)

  [<Test>]
  member this.
    ``Whether the right angled triangle is a triangle``()=
    triangle.IsTriangle |> should equal true

  [<Test>]
  member this.
    ``Whether the right angle check works`` ()=
    triangle.IsRightAngled |> should equal true

[<TestFixture>]
type ``Given some negative values`` () =
  let triangle = new Triangle(3.0,4.0,-5.0)

  [<Test>]
  member this.
    ``The triangle test should fail`` () =
    triangle.IsTriangle |> should equal false

//[<EntryPoint>]
//let main argv = 
//    printfn "%A" argv
//    0 // return an integer exit code