module Lesson14.Auditing

open Lesson14.Domain
open System.IO

let fileSystem account message =
    let directory = Path.Combine (@"C:\temp\learnfs\capstone2\", account.Owner.Name)
    Directory.CreateDirectory directory |> ignore
    let file = Path.Combine (directory, account.AccountId.ToString() + ".txt")
    File.WriteAllText (file, message)

let console account message =
    printfn "Account %A: %s" account.AccountId message
