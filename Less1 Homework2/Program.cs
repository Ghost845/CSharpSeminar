﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Напишите первое число для сравнения: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Напишите второе число для сравнения: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Напишите третье число для сравнения: ");
int thirdNum = Convert.ToInt32(Console.ReadLine());

if (firstNum > secondNum)
{
    if (firstNum > thirdNum)
    {
        Console.Write(firstNum);
    }
}
else
{
    if (secondNum > thirdNum)
    {
        Console.Write(secondNum);
    }
    else
    {
        Console.Write(thirdNum);
    }
}