// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
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
            newArray[i, j] = new Random().Next(1, 20);
            Console.Write($"{newArray[i, j]} ");
        }
        Console.WriteLine();
    }

    return newArray;
}
int[,] newArr = Array(m, n);
for (int i = 0; i < newArr.GetLength(1); i++)
{
    double sum = 0;
    for (int j = 0; j < newArr.GetLength(0); j++)
    {
        sum += newArr[j, i];
    }
    double average = sum / m;
    Console.Write($"{Math.Round(average, 1)} ");
}