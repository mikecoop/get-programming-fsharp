open System.IO
open System

let directories = Directory.EnumerateDirectories @"C:\"
let result =
    directories
    |> Seq.map DirectoryInfo
    |> Seq.map (fun d -> d.Name, d.CreationTimeUtc)
    |> Map.ofSeq
    |> Map.map (fun _ time -> (DateTime.UtcNow - time).TotalDays)
    |> Map.toList
