module Car

open System

let getDistance (destination) =
    if destination = "Gas" then 10
    elif destination = "Home" then 25
    elif destination = "Stadium" then 25
    elif destination = "Office" then 50
    else failwith "Unknown destination!"

let calculateRemainingPetrol (currentPetrol:int, distance:int) : int =
    if currentPetrol >= distance then currentPetrol - distance
    else failwith "Oops! You've run out of petrol!"

/// Drives to a given destination given a starting amount of petrol
let driveTo (petrol:int, destination:string) : int =
    let distance = getDistance destination
    let petrol = calculateRemainingPetrol (petrol, distance)
    if destination = "Gas" then petrol + 50
    else petrol
