// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Напишите первое число для сравнения: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Напишите второе число для сравнения: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if (firstNum > secondNum)
{
    Console.Write(firstNum);
}
else
{
    Console.Write(secondNum);
}