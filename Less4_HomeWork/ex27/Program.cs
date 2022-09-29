// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int temp = 0;
while (a > 0)
{
    temp = a % 10;
    sum += temp;
    a = a / 10;
}
Console.WriteLine(sum);