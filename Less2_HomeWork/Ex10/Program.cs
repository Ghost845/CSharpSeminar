// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int twoDigit = num % 100;
int result = twoDigit / 10;
Console.WriteLine($"{num} -> {result}");

// Дополнение, если нужна ошибка при введении не трёхзначного числа:
// Console.Clear();
// Console.Write("Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num <= 999 && num > 99)
// {
//     int twoDigit = num % 100;
//     int result = twoDigit / 10;
//     Console.WriteLine($"{num} -> {result}");
// }
// else
// {
//     Console.WriteLine("Введённое число не трёхзначное!");
// }