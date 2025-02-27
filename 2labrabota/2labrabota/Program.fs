open System
// Функция для подсчёта количества цифр в числе
let countchisel (n: int) =
    let mutable num = n
    let mutable count = 0
    if num = 0 then  // Учитываем случай, когда число равно 0
        count <- 1
    else
        while num > 0 do
            num <- num / 10
            count <- count + 1
    count

// Чтение числа с клавиатуры
printfn "Введите натуральное число:"
let vvod = Console.ReadLine()

// Преобразуем строку в число с обработкой исключений
try
    let chislo = int vvod  // Пытаемся преобразовать строку в число
    let Countchisel = countchisel chislo
    printfn "Количество цифр в числе: %d" Countchisel
with
| :? System.FormatException -> printfn "Ошибка: введено не число."