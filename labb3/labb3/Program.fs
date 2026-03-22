(*
open System

let last x = x % 10

[<EntryPoint>]
let main args =
    printf "сколько чисел вы хотите ввести? "
    let n = int(Console.ReadLine())

    let numbers =
        [ for i in 1 .. n do
            printf "Введите число %d: " i
            let num = int(Console.ReadLine())
            yield num ]

    let lastn = numbers |> List.map last

    printfn "Последние цифры введённых чисел: %A" lastn
    0
    *)
    (*
open System


let last x = x % 10

let sum d acc x =
    if last x = d then acc + x
    else acc

[<EntryPoint>]
let main args =

    printf "Сколько чисел вы хотите ввести? "
    let n = int(Console.ReadLine())

    let numbers =
        [ for i in 1 .. n do
            printf "Введите число %d: " i
            let num = int(Console.ReadLine())
            yield num ]
        |> Seq.ofList

    printf "Введите цифру для поиска: "
    let d = int(Console.ReadLine())

    let res = Seq.fold (sum d) 0 numbers

    printfn "Сумма чисел с последней цифрой %d = %d" d res
    0
    *)
