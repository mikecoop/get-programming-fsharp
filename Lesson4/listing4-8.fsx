open System
open System.Net
open System.Windows.Forms

(*let webClient = new WebClient()
let fsharpOrg = webClient.DownloadString(Uri "http://fsharp.org")
let browser =
    new WebBrowser(ScriptErrorsSuppressed = true,
                   Dock = DockStyle.Fill,
                   DocumentText = fsharpOrg)
let form = new Form(Text = "Hello from F#!")
form.Controls.Add(browser)
form.Show*)

let fSharpOrg url =
    let webClient = new WebClient()
    webClient.DownloadString (Uri url)

let form = new Form (Text = "Hello from F#!")
form.Controls.Add (new WebBrowser (ScriptErrorsSuppressed = true,
                                   Dock = DockStyle.Fill,
                                   DocumentText = fSharpOrg "http://fsharp.org"))
form.Show()
