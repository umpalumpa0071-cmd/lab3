(*
open System

let last seq =
    let r =
        seq |> Seq.map (fun x -> abs x % 10)
    printfn "результат: %A\n" (Seq.toList r)

[<EntryPoint>]
let main args =
    printf "Введите количество элементов n: "
    let n = int (Console.ReadLine())

    let seq =
        seq {
            for i in 1..n do
                printf "Введите элемент %d: " i
                let x = int (Console.ReadLine())
                yield x
        }

    last seq
    0
    *)
    (*
open System
let sum seq m =
    let result =
        Seq.fold (fun acc x ->
            if abs x % 10 = m then acc + x
            else acc
        ) 0 seq
    printf "сумма = %d\n" result

[<EntryPoint>]
let main args =
    printf "Введите количество элементов n: "
    let n = int (Console.ReadLine())

    let seq =
        seq {
            for i in 1..n do
                printf "Введите элемент %d: " i
                let x = int (Console.ReadLine())
                yield x
        }

    printf "Введите цифру: "
    let d = int (Console.ReadLine())

    sum seq d
    0
    *)
