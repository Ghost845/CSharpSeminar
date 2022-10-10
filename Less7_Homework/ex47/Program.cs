// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] Array(int m, int n)
{
    double[,] newArray = new double[m, n];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
            {
                newArray[i, j] = new Random().Next(-100, 100)/10.0;
                Console.Write($"{newArray[i, j]} ");
            }
            Console.WriteLine();
    }
    
    return newArray;
}
Console.WriteLine($"m = {m}, n = {n}");
Array(m, n);