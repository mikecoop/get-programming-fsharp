open System

/// Gets the distance to a given destination 
let getDistance (destination) =
    if destination = "Gas" then 10
    elif destination = "Home" then 25
    elif destination = "Stadium" then 25
    elif destination = "Office" then 50
    else failwith "Unknown destination!"

// Couple of quick tests
getDistance("Home") = 25
getDistance("Stadium") = 25

let calculateRemainingPetrol (currentPetrol:int, distance:int) : int =
    if currentPetrol >= distance then currentPetrol - distance
    else failwith "Oops! You've run out of petrol!"

calculateRemainingPetrol (25, 20)
calculateRemainingPetrol (25, 25)
calculateRemainingPetrol (20, 25)

let distanceToGas = getDistance "Gas"
calculateRemainingPetrol (25, distanceToGas)
calculateRemainingPetrol (5, distanceToGas)

let driveTo (petrol:int, destination:string) : int =
    let distance = getDistance destination
    let petrol = calculateRemainingPetrol (petrol, distance)
    if destination = "Gas" then petrol + 50
    else petrol
        
let a = driveTo (100, "Office")
let b = driveTo (a, "Stadium")
let c = driveTo (b, "Gas")
let answer = driveTo (c, "Home")