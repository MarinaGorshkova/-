// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Введите любое число больше нуля: ");
int num = Convert.ToInt32(Console.ReadLine());
do
{
    if (num <= 0)
    {
        Console.Write("Число меньше или равно нулю. Введите снова: ");
        Int32.TryParse(Console.ReadLine(), out num);
    }
}while(num <= 0); 
for (int i = 1; i < num+1; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i + " ");
    }
}