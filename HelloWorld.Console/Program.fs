// Learn more about F# at http://fsharp.org

open System

// %s string
// %d some form of int
// %f some form of float / decimal
// %b bool
// %A pretty print tuple, record types, union cases
// %O obj.ToString()

let myFunc arg1 arg2 = 
    printfn "%b" arg1
    0

let helloWorld =
    printfn "Hello World from %s!"

[<EntryPoint>]
let main argv =
    argv |> Array.iter helloWorld
    0 // return an integer exit code
