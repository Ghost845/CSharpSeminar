// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
Console.Write("Введите номер строки, в которой находится элемент: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца, в котором находится элемент: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] Array(int m, int n)
{
    int[,] newArray = new int[m, n];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(1, 10);
            Console.Write($"{newArray[i, j]} ");
        }
        Console.WriteLine();
    }
    return newArray;
}
int[,] newArray = Array(m, n);
if (line <= m && column <= n)
{
    Console.WriteLine(newArray[line - 1, column - 1]);
}
else
{
    Console.WriteLine($"Элемента с номерами позиций: [{line}, {column}] в массиве нет");
}