// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7)
{
    Console.WriteLine("Введено неверное значение!");
}
else if (day == 1)
{
    Console.WriteLine($"{day} -> нет");
}
else if (day == 2)
{
    Console.WriteLine($"{day} -> нет");
}
else if (day == 3)
{
    Console.WriteLine($"{day} -> нет");
}
else if (day == 4)
{
    Console.WriteLine($"{day} -> нет");
}
else if (day == 5)
{
    Console.WriteLine($"{day} -> нет");
}
else if (day == 6)
{
    Console.WriteLine($"{day} -> да");
}
else if (day == 7)
{
    Console.WriteLine($"{day} -> да");
}