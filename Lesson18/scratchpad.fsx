
let sum inputs =
    let mutable accumulator = 0
    for input in inputs do
        accumulator <- accumulator + input
    accumulator

let length inputs =
    let mutable accumulator = 0
    for _ in inputs do
        accumulator <- accumulator + 1
    accumulator

let maximum inputs =
    let mutable accumulator = 0
    for input in inputs do
        if input > accumulator then
            accumulator <- input
        else ()
    accumulator

let sum1 inputs =
    Seq.fold
        (fun state input -> state + input)
        0
        inputs

let length1 = Seq.fold (fun s _ -> s + 1) 0

let max1 = Seq.fold (fun s i -> max s i) 0

[ 1; 2; 3; 4; 5 ] |> length1

[ 6; 1; 2; 3; 9 ] |> max1
