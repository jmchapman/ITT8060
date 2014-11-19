// Michael R. Hansen  Nim Assignment  19-11-2014
// Skeleton Program 

// Upload the solution to your GIT repository into directory called coursework9

// Prelude
open System 
open System.Net 
open System.Threading 
open System.Windows.Forms 
open System.Drawing 


type AsyncEventQueue<'T>() = 
    let mutable cont = None 
    let queue = System.Collections.Generic.Queue<'T>()
    let tryTrigger() = 
        match queue.Count, cont with 
        | _, None -> ()
        | 0, _ -> ()
        | _, Some d -> 
            cont <- None
            d (queue.Dequeue())

    let tryListen(d) = 
        if cont.IsSome then invalidOp "multicast not allowed"
        cont <- Some d
        tryTrigger()

    member x.Post msg = queue.Enqueue msg; tryTrigger()
    member x.Receive() = 
        Async.FromContinuations (fun (cont,econt,ccont) -> 
            tryListen cont)



// The window part
let window =
  new Form(Text="Play NIM", Size=Size(800,650))

let infoBox =
  new TextBox(Location=Point(50,25),Size=Size(400,25))

let inputBox =
  new TextBox(Location=Point(50,75),Size=Size(400,25))

let statusBox = 
   new TextBox(Location=Point(50,200),Size=Size(400,25))

let gameBox = 
  new TextBox(Location=Point(50,275),Size=Size(400,370))

gameBox.Multiline <- true
gameBox.AcceptsReturn <- true


let newGameButton =
  new Button(Location=Point(50,115),MinimumSize=Size(100,50),
              MaximumSize=Size(100,50),Text="NEW GAME")

let moveButton =
  new Button(Location=Point(200,115),MinimumSize=Size(100,50),
              MaximumSize=Size(100,50),Text="MOVE")

let quitButton =
  new Button(Location=Point(350,115),MinimumSize=Size(100,50),
              MaximumSize=Size(100,50),Text="QUIT")

let fetchButton =
  new Button(Location=Point(500,115),MinimumSize=Size(100,50),
              MaximumSize=Size(100,50),Text="FETCH")

let cancelButton = 
  new Button(Location=Point(650,115),MinimumSize=Size(100,50),
              MaximumSize=Size(100,50),Text="CANCEL")

let disable bs = 
    for b in [newGameButton;moveButton;quitButton;fetchButton;cancelButton] do 
        b.Enabled  <- true
    for (b:Button) in bs do 
        b.Enabled  <- false

// No changes is needed above this comment

type Heap = int
type Game = Heap[]     // invariant: there is at least one heap in game g

type Move = int * int  // (i,n) remove n matches for heap g.[i]

type Player = | You   // the user
              | Me    // the computer


type Message = | NewGame of string     // a string of n>0 integers "  I1    I2     ...  In  
               | Quit                  // Give up current game
               | UserMove of string    // String with two integers for a move
               | Fetch                 // Fetch a game
               | Cancel                // to cancel a download
               ;;  



// allHeapsEmpty: Game -> bool
// checks whether all heaps are empty                         
// Should be implemented


// myMove: Game -> Move
// Should be implemented

// performMove: Game -> Move -> Game
// Should be implemented


// gameToString: Game -> string                           
let gameToString (g: Game) = let stra = Array.mapi (fun i n -> string i + ": " + string n) g
                             String.concat "  ;  " stra;; 
                              
// moveToString: Move -> string
let moveToString (h,n) = let str = string h + "  " + string n
                         function 
                         | You -> "Your move: " + str
                         | Me  -> "My move  : " + str  

// isIntegerString: string -> bool
let isIntegerString str = String.forall Char.IsDigit str

// moveOfString: Game -> string -> Move option
let moveOfString (g: Game) (str:string) =               
               let stra = str.Split([|' '|],System.StringSplitOptions.RemoveEmptyEntries)
               if stra.Length = 2 && isIntegerString(stra.[0]) && isIntegerString(stra.[1])
               then let (h,n) = (int stra.[0], int stra.[1])
                    if 0 <= h && h < g.Length && 0<n && n <= g.[h] then Some(h,n) 
                    else None
               else None;;

// gameOfString: string -> Game option
let gameOfString (str:string) = let stra = str.Split([|' '|],System.StringSplitOptions.RemoveEmptyEntries)
                                if stra.Length > 0 && Array.forall isIntegerString stra
                                then let g = Array.map int stra
                                     if Array.forall (fun n -> n>0) g then Some g
                                     else None
                                else None

// printMove: Game -> Move -> Player -> unit
let printMove (g: Game) mv player = gameBox.AppendText ("\r\n" + gameToString g + "    " + moveToString mv player) 


let ev = AsyncEventQueue()                                                         

// init: unit -> Async(unit) 
// myTurn: Game -> Async(unit)
// yourTurn: Game -> Async(unit)
let rec init() = 
   async{infoBox.Text   <- "New game: state sizes of the heaps"
         inputBox.Text  <- ""
         gameBox.Text   <- ""
         disable [moveButton; quitButton; cancelButton]

         let! msg = ev.Receive()
         match msg with           
         | NewGame str -> match gameOfString str with
                          | Some g -> statusBox.Text <- ""
                                      gameBox.Text <- gameToString g
                                      return! userTurn g
                          | None   -> return! init() 
//         | Fetch       ->  return! loading(Uri @"http://www2.compute.dtu.dk/~mire/nim.game")  
//   This comment should be deleted in Part 2 of the assignment

         | _           -> failwith "unexpected message"}
                                                        
and myTurn g = 
   async{let mv = myMove g
         let g' = performMove g mv
         printMove g' mv Me 
         if allHeapsEmpty g' then statusBox.Text <- "I won"
                                  return! init()
         else return! userTurn g'}
                        
and userTurn g = 
   async{infoBox.Text <- "state heap and number of removed matches"
         inputBox.Text <- ""
         disable [newGameButton; fetchButton; cancelButton]

         let! msg = ev.Receive()
         match msg with
         | UserMove str -> match moveOfString g str with 
                           | Some mv -> let g' = performMove g mv 
                                        printMove g' mv You
                                        if allHeapsEmpty g' then statusBox.Text <- "You won"
                                                                 return! init()
                                        else return! myTurn g'
                           | None    -> statusBox.Text <- "illegal input"
                                        return! userTurn g                                                        
         | _           -> failwith "unexpected message"};;


// No changes will be needed below this comment                                                                 
// Initialization
window.Controls.Add infoBox
window.Controls.Add inputBox
window.Controls.Add statusBox
window.Controls.Add gameBox
window.Controls.Add newGameButton
window.Controls.Add moveButton
window.Controls.Add fetchButton
window.Controls.Add quitButton
window.Controls.Add cancelButton 
cancelButton.Click.Add (fun _ -> ev.Post Cancel)
newGameButton.Click.Add (fun _ -> ev.Post (NewGame inputBox.Text))
fetchButton.Click.Add (fun _ -> ev.Post Fetch)
moveButton.Click.Add (fun _ -> ev.Post (UserMove inputBox.Text))
quitButton.Click.Add (fun _ -> ev.Post Quit)

// Start
Async.StartImmediate (init())
window.Show()    
