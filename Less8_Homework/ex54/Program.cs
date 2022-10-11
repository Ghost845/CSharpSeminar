// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задан массив: ");
int[,] newArr = Array(m, n);
OrderArray(newArr);
Console.WriteLine();
WriteArray(newArr);


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

void OrderArray(int[,] array)
{
    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            for (int k = 0; k < newArr.GetLength(1) - 1; k++)
            {
                if (newArr[i, k] < newArr[i, k + 1])
                {
                    int temp = newArr[i, k + 1];
                    newArr[i, k + 1] = newArr[i, k];
                    newArr[i, k] = temp;
                }
            }
        }
    }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}