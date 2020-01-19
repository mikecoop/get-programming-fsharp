#load "Domain.fs"
#load "Operations.fs"

open Capstone3.Operations
open Capstone3.Domain
open System

let isValidCommand (command:char) =
    [ 'd'; 'w'; 'x' ] |> List.contains command

let isStopCommand (command:char) = command = 'x'

let getAmount = function
    | 'd' -> ( 'd', 50M )
    | 'w' -> ( 'w', 25M )
    | _ -> ( 'x', 0M )

let processCommand (account:Account) (command:char, amount:decimal) : Account =
    if command = 'd' then (account |> deposit amount)
    elif command = 'w' then (account |> withdraw amount)
    else account

let openingAccount =
    { Owner = { Name = "Mike"}; Balance = 0M; AccountId = Guid.Empty }

let account =
    let commands = [ 'd'; 'w'; 'z'; 'f'; 'd'; 'x'; 'w' ]

    commands
    |> Seq.filter isValidCommand
    |> Seq.takeWhile (not << isStopCommand)
    |> Seq.map getAmount
    |> Seq.fold processCommand openingAccount
