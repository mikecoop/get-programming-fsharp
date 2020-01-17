
let parseName (name:string) =
    let parts = name.Split (' ')
    let forename = parts.[0]
    let surname = parts.[1]
    forename, surname

let name = parseName ("Michael Cooper")
let forename, surname = name
let fname, sname = parseName ("Michael Cooper")

let parse (person:string) =
    let parts = person.Split (' ')
    let playerName = parts.[0]
    let game = parts.[1]
    let score = int parts.[2]
    playerName, game, score

let value = parse "Mary Asteroids 2500"
let n, g, s = value

open System.IO

let getFileNameAndLastModifiedTime (file:string) =
    let lastModified = File.GetLastWriteTime file
    file, lastModified

getFileNameAndLastModifiedTime @"C:\Users\mcooper\Downloads\get-programming-with-fsharp\src\code-listings\lesson-08\Program.cs"
