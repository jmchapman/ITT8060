// Lecture 15
// Data science in F#

#I ".."
#load "packages/FsLab.0.0.19/FsLab.fsx"


open FSharp.Data

let wb = WorldBankData.GetDataContext()

//wb.Countries.Estonia.CapitalCity

wb.Countries.Estonia.CapitalCity

let countries = wb.Regions.``Euro area``

open Deedle

let debts = 
  [ for c in countries.Countries -> 
      let debts = c.Indicators.``Central government debt, total (% of GDP)``
      c.Name => series debts ] |> frame

let recent = debts.Rows.[2005 ..]

recent 
|> Stats.mean
|> Series.sort
|> Series.rev
|> Series.take 5
|> round

open MathNet.Numerics.LinearAlgebra

let debtsMat = debts |> Frame.fillMissingWith 0.0 |> Frame.toMatrix
let avgVect = debts  |> Stats.mean  |> Series.toVector

debtsMat * avgVect

open FSharp.Charting

Chart.Combine(
  [ Chart.Line(recent?Cyprus, Name="Cyprus")
    Chart.Line(recent?Malta, Name="Malta")
    Chart.Line(recent?Italy, Name = "Italy")
    Chart.Line(recent?Greece, Name = "Greece")
  ])
  .WithLegend()

let fb = FreebaseData.GetDataContext()

fb.Society.Government.``Government Service Types``.Individuals.``Public service``

