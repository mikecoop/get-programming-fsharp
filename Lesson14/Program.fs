module Lesson14.Program

open System
open Lesson14.Domain
open Operations

[<EntryPoint>]
let main argv =
    let mutable account =
        let customer =
            Console.Write "Please enter your name: "
            let customerName = Console.ReadLine()
            { Name = customerName }

        Console.Write "Enter opening balance: "
        let balance = Console.ReadLine() |> Decimal.Parse
        { AccountId = Guid.NewGuid()
          Owner = customer
          Balance = balance }

    let withdrawWithAudit = withdraw |> auditAs "withdraw" Auditing.fileSystem
    let depositWithAudit = deposit |> auditAs "deposit" Auditing.fileSystem

    while true do
        let action =
            Console.WriteLine()
            printfn "Current balance is £%M" account.Balance
            Console.Write "(d)eposit, (w)ithdraw or e(x)it: "
            Console.ReadLine()

        if action = "x" then Environment.Exit 0

        let amount =
            Console.Write "Amount: "
            Console.ReadLine() |> Decimal.Parse

        // Mutate account value via an expression
        account <-
            if action = "d" then account |> depositWithAudit amount
            elif action = "w" then account |> withdrawWithAudit amount
            else account

    0 // return an integer exit code