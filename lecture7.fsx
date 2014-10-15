(*

   Lecture Oct 15, 2014: Data centric and behaviour centric
   programs.

   Based on Chapter 7 and Chapter 8 of RWFP.
   
*)

type Rect =
 { Left  : float32
   Top   : float32
   Width : float32
   Height: float32
 }

// C# anonymous types
// var smth = {Left = 1.0f, Top =  }

let rc = {Left = 10.0f; Top = 10.0f ; Width = 100.0f ; Height=200.0f}

rc.Left + rc.Width

let rc2awk = {Left = rc.Left + 100.0f ; Top = rc.Top ;
       Width = rc.Width; Height=rc.Height}

let rc2 = {rc with Left = rc.Left + 100.0f}


open System.Drawing

type TextContent =
  { Text : string
    Font : Font }

type Orientation = 
  | Vertical
  | Horizontal

type DocumentPart =
  | SplitPart of Orientation * list<DocumentPart>
  | TitledPart of TextContent * DocumentPart
  | TextPart of TextContent
  | ImagePart of string

let fntText = new Font("Verdana", 12.0f)
let fntHead = new Font("Verdana", 15.0f)

let doc = 
  TitledPart({Text = "ITT8060 Class 2014"; 
              Font = fntHead},
              SplitPart(Vertical, 
              [ImagePart("image.png");
               TextPart({Text = "..." ; Font = fntText})]))

#r "System.Xml.Linq.dll"
open System.Xml.Linq

let attr(node:XElement, name, defaultValue) =
  let attr = node.Attribute(XName.Get(name))
  if (attr <> null) then attr.Value else defaultValue

let parseOrientation(node) = 
  match attr(node,"orientation","") with
  | "horizontal" -> Horizontal
  | "vertical"   -> Vertical
  | _            -> failwith "Unknown orientation!" 


let parseFont(node) =
  new Font("Verdana", 12.0f, FontStyle.Regular)

let rec loadPart(node:XElement) =
  match node.Name.LocalName with
  | "titled" ->
    let tx = {Text = attr(node,"title", "");
              Font = parseFont(node) }
    let body = loadPart (Seq.head(node.Elements()))
    TitledPart(tx,body)
  | "split"  -> 
    let orient = parseOrientation node
    let nodes = node.Elements() |> List.ofSeq |> List.map loadPart
    SplitPart(orient,nodes)
  | "text"   ->
    TextPart({Text = node.Value; Font = parseFont node})
  | "image"  -> 
    ImagePart(attr(node,"filename",""))
  | name -> failwith("Unknown node: "+name)

let rec aggregateDocument f state docPart =
  let state = f state docPart
  match docPart with
  | TitledPart(_,part) ->
    aggregateDocument f state part
  | SplitPart(_, parts) ->
    List.fold (aggregateDocument f) state parts
  | _ -> state

let totalWords document = 
  aggregateDocument (fun count part -> 
    match part with
    | TextPart(tx) | TitledPart(tx,_) ->
      count + tx.Text.Split(' ').Length
    | _ -> count)
    0 document


let doc2 = loadPart(XDocument.Load(@"c:\tmp\live7.xml").Root)

totalWords doc2




























