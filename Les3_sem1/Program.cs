// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("введите число");

int num = Convert.ToInt32(Console.ReadLine());

if (num == 0)

{
    Console.WriteLine("Введите любое число, кроме 0");
    Int32.TryParse(Console.ReadLine(), out num);
}

if (num % 2 == 0)

{
    Console.WriteLine("Да");
}

else 

{
    Console.WriteLine("Нет");
}