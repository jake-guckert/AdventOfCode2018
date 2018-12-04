// Learn more about F# at http://fsharp.org

open System
open System.IO

 let op (a:char, b:int) : int = 
    match a with
     | '+' -> b
     | '-' -> b*(-1)
     | _ -> b

let strToNum (s:string) : int = 
    let r = op(s.[0], s.[1..] |> int)
    r

[<EntryPoint>]
let main argv =
    File.ReadLines "input.txt"
    |> Seq.fold (fun acc elem -> acc + strToNum(elem)) 0
    |> printfn "%d"
    0