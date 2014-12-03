// lecture 14

// duality, push/pull, IEnumerable/IObservable, rx (reactive extensions)

#r "FSharp.PowerPack.dll"
#I "/Users/james/repos/FSharp.Control.Reactive/bin"
#r "System.Reactive.Core.dll"
#r "System.Reactive.Interfaces.dll"
#r "System.Reactive.Linq.dll"
#r "System.Reactive.Providers.dll"
#r "System.Reactive.PlatformServices.dll"
#r "System.Reactive.Experimental.dll"
#r "FSharp.Control.Reactive.dll"
open System
open System.Reactive.Linq
open FSharp.Control.Reactive
open Builders

open System.Reactive.Linq

let obs1 = Observable.Return(42)
obs1.Subscribe(printfn "%d")

let enu1 = [ 1 ]
for i in enu1 do printfn "%d" i

let obs2 = Observable.Empty<int>()
obs2.Subscribe(printfn "%d")

let enu2 = []
for i in enu2 do printfn "%d" i

let obs3 = Observable.Never<int>()
obs3.Subscribe(printfn "%d")

// dual to stuck iterator

let obs4 = Observable.Throw<int>(new System.Exception("error"))
obs4.Subscribe(printfn "%d")

let obs5 = Observable.Range(0,3)
let enu5 = [ 0 .. 3 ]

let obs6 = Observable.Generate(
  0,
  (fun i -> i < 10),
  (fun i -> i + 1),
  (fun i -> i * i))

let sub1 = obs6.Subscribe(printfn "%d")
sub1.Dispose()

open System.IO
let fileWatcher = new FileSystemWatcher(@"/Users/james/test")
fileWatcher.EnableRaisingEvents <- true

// imperative style
fileWatcher.Created.Add(fun fse ->
                        if not (fse.Name.EndsWith("~")) then printfn "new file!) %s" fse.Name)

let isRealFile (fse:FileSystemEventArgs) = fse.Name.EndsWith("~") |> not

let formatCreatedEvent (fse:FileSystemEventArgs) = sprintf "new file! %s" fse.Name

let sub2 =
  fileWatcher.Created
  |> Observable.filter isRealFile
  |> Observable.map formatCreatedEvent
  |> Observable.subscribe(printfn "%s")
sub2.Dispose()


// fizzbuzz

let createTimerAndObservable timerInterval =
    // setup a timer
    let timer = new System.Timers.Timer(float timerInterval)
    timer.AutoReset <- true

    // events are automatically IObservable
    let observable = timer.Elapsed  

    // return an async task
    let task = async {
        timer.Start()
        do! Async.Sleep 5000
        timer.Stop()
        }

    // return a async task and the observable
    (task,observable)

type FizzBuzzEvent = {label:int; time: DateTime}

let areSimultaneous (earlierEvent,laterEvent) =
    let {label=_;time=t1} = earlierEvent
    let {label=_;time=t2} = laterEvent
    t2.Subtract(t1).Milliseconds < 50
    

// create the event streams and raw observables
let timer3, timerEventStream3 = createTimerAndObservable 300
let timer5, timerEventStream5 = createTimerAndObservable 500

// convert the time events into FizzBuzz events with the appropriate id
let eventStream3  = timerEventStream3  
                    |> Observable.map (fun _ -> {label=3; time=DateTime.Now})
let eventStream5  = timerEventStream5  
                    |> Observable.map (fun _ -> {label=5; time=DateTime.Now})

// combine the two streams
let combinedStream = 
   Observable.merge eventStream3 eventStream5
 
// make pairs of events
let pairwiseStream = 
   combinedStream |> Observable.pairwise
 
// split the stream based on whether the pairs are simultaneous
let simultaneousStream, nonSimultaneousStream = 
   pairwiseStream |> Observable.partition areSimultaneous

// split the non-simultaneous stream based on the id
let fizzStream, buzzStream  =
    nonSimultaneousStream  
    // convert pair of events to the first event
    |> Observable.map (fun (ev1,_) -> ev1)
    // split on whether the event id is three
    |> Observable.partition (fun {label=id} -> id=3)

//print events from the combinedStream
combinedStream 
|> Observable.subscribe (fun {label=id;time=t} -> 
                              printf "[%i] %i.%03i " id t.Second t.Millisecond)
 
//print events from the simultaneous stream
simultaneousStream 
|> Observable.subscribe (fun _ -> printfn "FizzBuzz")

//print events from the nonSimultaneous streams
fizzStream 
|> Observable.subscribe (fun _ -> printfn "Fizz")

buzzStream 
|> Observable.subscribe (fun _ -> printfn "Buzz")

// run the two timers at the same time
[timer3;timer5]
|> Async.Parallel
|> Async.RunSynchronously
