namespace Dynamic

open WebSharper
open WebSharper.JavaScript
open WebSharper.UI
open WebSharper.UI.Client
open WebSharper.UI.Templating

module Client =
    let myFunction () = ()

    [<SPAEntryPoint>]
    let Main() =
        myFunction ()

[<assembly:JavaScript>]
do ()