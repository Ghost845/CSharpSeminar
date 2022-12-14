// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] newArr = Array(m, n);

int minSum = 0;
int sumLine = SumElements(newArr, 0);
for (int i = 1; i < newArr.GetLength(0); i++)
{
  int tempSumLine = SumElements(newArr, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSum = i;
  }
}

Console.WriteLine($"Строкa с наименьшей суммой ({sumLine}) элементов: {minSum+1}");

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

int SumElements(int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i,j];
  }
  return sum;
}