
let tupledAdd (a, b) = a + b

let answer1 = tupledAdd (1, 2)

let curriedAdd a b = a + b

let answer2 = curriedAdd 1 2

let add first second = first + second

let addFive = add 5

let fifteen = addFive 10

open System

let buildDt year month day = DateTime(year, month, day)
let buildDtThisYear = buildDt DateTime.UtcNow.Year
let buildDtThisMonth = buildDtThisYear DateTime.UtcNow.Month

open System.IO

let writeToFile (date:DateTime) filename text =
    let path = sprintf "%A-%A.txt" (date.ToString "yyMMdd") filename
    File.WriteAllText (path, text)

let time =
    let directory = Directory.GetCurrentDirectory()
    Directory.GetCreationTime directory

let drive distance petrol = petrol

let startingPetrol = 100.0
let petrol1 = drive startingPetrol "far"
let petrol2 = drive petrol1 "medium"
let petrol3 = drive petrol2 "short"

startingPetrol |>
drive "far" |>
drive "medium" |>
drive "short"


