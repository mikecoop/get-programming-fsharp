
type FootballResult =
    { HomeTeam: string
      AwayTeam: string
      HomeGoals: int
      AwayGoals: int }

let create (ht, hg) (at, ag) =
    { HomeTeam = ht; AwayTeam = at; HomeGoals = hg; AwayGoals = ag }

let result =
    [ create ("Messiville", 1) ("Ronaldo City", 2)
      create ("Messiville", 1) ("Bale Town", 3)
      create ("Bale Town", 3) ("Ronaldo City", 1)
      create ("Bale Town", 2) ("Messiville", 1)
      create ("Ronaldo City", 4) ("Messiville", 2)
      create ("Ronaldo City", 1) ("Bale Town", 2) ]

let awayWins =
    result
    |> List.filter (fun r -> r.AwayGoals > r.HomeGoals)
    |> List.countBy (fun r -> r.AwayTeam)
    |> List.sortByDescending snd

let numbersArray = [| 1; 2; 3; 4; 6 |]
let firstNumber = numbersArray.[0]
let firstThreeNumbers = numbersArray.[0..2]
numbersArray.[0] <- 99

let numbers = [ 1; 2; 3; 4; 5; 6 ]
let numbersQuick = [ 1..6 ]
let head :: tail = numbers
let moreNumbers = 0 :: numbers
let evenMoreNumbers = moreNumbers @ [ 7..9 ]