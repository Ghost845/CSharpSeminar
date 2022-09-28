// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int length = n;
int i = 1;

while ( i < length )
{
    Console.Write($"{Math.Pow(i, 3)} ");
    i++;
}

// Без массива
// Console.Write("Введите любое число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i < num + 1; i++)
//     Console.Write($"{Math.Pow(i, 3)} ");