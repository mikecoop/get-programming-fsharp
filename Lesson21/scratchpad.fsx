
type Disk =
| HardDisk of Rpm: int * Platters: int
| SolidState
| MMC of NumberOfPins: int

let myHardDisk = HardDisk (Rpm = 2500, Platters = 7)
let myHardDiskShort = HardDisk (2500, 7)
let args = 250, 7
let myHardDiskTupled = HardDisk args
let myMMC = MMC 5
let mySSD = SolidState

let describe = function
    | SolidState -> "I'm a newfangled SSD."
    | MMC 1 -> "I have only 1 pin."
    | MMC pins when pins < 5 -> "I'm an MMC with a few pins."
    | MMC pins -> sprintf "I'm an MMC with %i pins." pins
    | HardDisk (5400, 0) -> "I'm a slow hard disk."
    | HardDisk (_, 7) -> "I have 7 spindles!"
    | HardDisk _ -> "I'm a hard disk."
