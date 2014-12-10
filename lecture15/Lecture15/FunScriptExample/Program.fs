
[<ReflectedDefinition>]
module Program

open FunScript
open FunScript.TypeScript
open FSharp.Data

type WorldBank = WorldBankDataProvider<Asynchronous=true>

let jq(selector:string) = Globals.Dollar.Invoke selector
let (?) jq name = jq("#" + name)

let data = WorldBank.GetDataContext()

let countries () = 
  [| data.Countries.Estonia
     data.Countries.``European Union``
     data.Countries.Latvia
  |]

let makeCheckInfos() = 
   countries () |> Array.mapi (
     fun index country -> 
       let input = jq("<input>")
       input.attr("type", "checkbox") |> ignore
       let label = jq("<label>")
       label.append( [| box input |] ) |> ignore
       label.append( [| box country.Name |]) |> ignore
       let panel = (index % 2) + 1
       let panelId = "#countryList" + panel.ToString()
       label.appendTo(jq(panelId)) |> ignore
       country, input )

let main() = 
  let infos = makeCheckInfos()

  // Render the chart based on checkboxes
  let render () = async {
    // Create a line chart
    let opts = createEmpty<HighchartsOptions>()
    let titleOptions = createEmpty<HighchartsTitleOptions>()
    titleOptions.text <- "School enrollment, tertiary (% gross)"
    opts.title <- titleOptions
    let subTitleOptions = createEmpty<HighchartsSubtitleOptions>()
    subTitleOptions.text <- "Source: WorldBank"
    opts.subtitle <- subTitleOptions
    opts.series <- [| |]
    
    
    // Create series we want to render
    for country, check in infos do
      if check._is ":checked" then
        // Asynchronously load data without blocking
        let! vals = country.Indicators.``School enrollment, tertiary (% gross)``
        // Convert data to format required by HighCharts
        let data = 
            vals
            |> Seq.map (fun (k, v) ->
                let p = createEmpty<HighchartsDataPoint>() 
                p.x <- number k
                p.y <- number v
                p)
            |> Seq.toArray
        // Create new data series and add it to the chart
        let series = createEmpty<HighchartsSeriesOptions>()
        series.data <- unbox data
        series.name <- country.Name
        series._type <- "line"
        
        opts.series.pushOverload2(series) |> ignore
    // Invoke constructor on a chart prototype
    let chartElement = jq?chart
    chartElement.highcharts(opts) |> ignore
  }

  // Register click handlers
  render () |> Async.StartImmediate
  infos |> Array.iter (fun (_, check) ->
    // When checkbox is clicked, start the 'render' workflow
    check.click(fun _ -> 
      render() |> Async.StartImmediate |> box) |> ignore)


let components = 
  FunScript.Data.Components.getDataProviders()
do FunScript.Runtime.Run(components=components, directory="Web")