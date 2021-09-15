// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let isFizzBuzz value =
  (value % 15) = 0

let isFizz value =
  (value % 3) = 0

let isBuzz value =
  (value % 5) = 0

let output (value : int) =
  if isFizzBuzz value then
    "FizzBuzz"
  else if isFizz value then
    "Fizz"
  else if isBuzz value then
    "Buzz"
  else
    string value

[<EntryPoint>]
let main argv =
  let message = 
    seq { for i in 1..100 do output i}
    |> String.concat " "
  printfn "%s" message
  printfn "Done"
  0