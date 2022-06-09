namespace Templates

open WebSharper.UI.Templating

type MainTemplate = Template<"../Online/Main.html", serverLoad = ServerLoad.WhenChanged>