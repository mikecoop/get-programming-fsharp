module Capstone3.Program

open System
open Capstone3.Domain
open Capstone3.Operations

let isValidCommand (command:char) =
    [ 'd'; 'w'; 'x' ] |> List.contains command

let isStopCommand (command:char) = command = 'x'

let getAmount = function
    | 'd' -> ( 'd', 50M )
    | 'w' -> ( 'w', 25M )
    | _ -> ( 'x', 0M )
       
let withdrawWithAudit = auditAs "withdraw" Auditing.composedLogger withdraw
let depositWithAudit = auditAs "deposit" Auditing.composedLogger deposit

let processCommand (account:Account) (command:char, amount:decimal) : Account =
    if command = 'd' then (account |> depositWithAudit amount)
    elif command = 'w' then (account |> withdrawWithAudit amount)
    else account


[<EntryPoint>]
let main _ =
    let name =
        Console.Write "Please enter your name: "
        Console.ReadLine()


    let openingAccount = { Owner = { Name = name }; Balance = 0M; AccountId = Guid.Empty } 

    let consoleCommands = seq {
        while true do
            Console.Write "(d)eposit, (w)ithdraw or e(x)it: "
            yield Console.ReadKey().KeyChar }

    let getAmountConsole command =
        Console.WriteLine()
        Console.Write "Enter Amount: "
        command, Console.ReadLine() |> Decimal.Parse

    let closingAccount =
        consoleCommands
        |> Seq.filter isValidCommand
        |> Seq.takeWhile (not << isStopCommand)
        |> Seq.map getAmountConsole
        |> Seq.fold processCommand openingAccount

    Console.Clear()
    printfn "Closing Balance:\r\n %A" closingAccount
    Console.ReadKey() |> ignore

    0