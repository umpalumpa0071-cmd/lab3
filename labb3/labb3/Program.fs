(*
open System

let last seq =
    let r =
        seq |> Seq.map (fun x -> abs x % 10)
    printf "результат: %A\n" r

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
