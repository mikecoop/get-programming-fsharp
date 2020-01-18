
type Customer = { Age: int }

let where filter customers =
    seq { for customer in customers do
            if filter customer then
                yield customer }

let customers = [ { Age = 21}; { Age = 35}; { Age = 36 } ]
let isOver35 customer = customer.Age > 35

customers |> where isOver35
customers |> where (fun customer -> customer.Age > 35)

let printCustomerAge writer customer =
    let age customer =
        if customer.Age < 13 then "Child"
        elif customer.Age < 20 then "Teenager"
        else "Adult"
    writer (age customer)

let printToConsole = printCustomerAge System.Console.WriteLine

printToConsole { Age = 12 }

printToConsole { Age = 15 }

printToConsole { Age = 20 }
