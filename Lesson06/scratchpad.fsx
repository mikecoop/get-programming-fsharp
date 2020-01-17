
open System.Windows.Forms
let form = new Form(Text = "Hello from F#!", Width = 300, Height = 300)

let mutable petrol = 100.0

let drive distance =
    if distance = "far" then petrol <- petrol / 2.0
    elif distance = "medium" then petrol <- petrol - 10.0
    else petrol <- petrol - 1.0

drive "far"
drive "medium"
drive "short"

petrol

let drive1 petrol distance =
    if distance = "far" then petrol / 2.0
    elif distance = "medium" then petrol - 10.0
    else petrol - 1.0

let petrol1 = 100.0
let firstState = drive1 petrol1 "far"
let secondState = drive1 firstState "medium"
let thirdState = drive1 secondState "short"

let drive2 petrol distance =
    if distance > 50 then petrol / 2.0
    elif distance > 25 then petrol - 10.0
    elif distance > 1 then petrol - 1.0
    else petrol
