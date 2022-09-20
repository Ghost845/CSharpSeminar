// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int index = num;
if (num / 100 == 0)
{
    Console.WriteLine($"{num} -> третьей цифры нет");
}
else
{
    while (index > 999)
    {
        index = index / 10;
    }
    Console.WriteLine($"{num} -> {index % 10}");
}
