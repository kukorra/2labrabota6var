open System

let rec countDigits (n : int) =
    if n < 0 then
        failwith "Число должно быть натуральным (положительным)."
    else if n < 10 then
        1
    else
        1 + countDigits (n / 10)

[<EntryPoint>]
let main argv =
    printfn "Введите натуральное число:"
    let input = Console.ReadLine()

    try
        let number = Int32.Parse input
        if number < 0 then
            printfn "Пожалуйста, введите натуральное (положительное) число."
        else
            let digitCount = countDigits number
            printfn "Количество цифр в числе %d: %d" number digitCount
    with
    | :? FormatException ->
        printfn "Ошибка: Введен некорректный формат числа."
    | ex ->
        printfn "Произошла ошибка: %s" ex.Message

    Console.ReadKey() |> ignore
    0

