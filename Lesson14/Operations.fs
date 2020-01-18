module Lesson14.Operations

open Lesson14.Domain

let deposit (amount:decimal) (account:Account) : Account =
    { account with Balance = account.Balance + amount }

let withdraw (amount:decimal) (account:Account) : Account =
    if amount > account.Balance then account
    else { account with Balance = account.Balance - amount }

let auditAs (operationName:string) (audit:Account -> string -> unit) (operation:decimal -> Account -> Account) (amount:decimal) (account:Account) : Account =
    audit account (sprintf "Performing a %s operation for $%M..." operationName amount)
    let updated = operation amount account
    if updated.Balance = account.Balance then
        audit account "Transaction was rejected!"
    else
        audit account (sprintf "Transaction accepted! Balance is now $%M" updated.Balance)
    updated
