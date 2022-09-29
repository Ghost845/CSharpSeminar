// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int[] array = new int[16];
int length = array.Length;
for(int i = 0; i < length; i++)
{
    array[i] = new Random().Next(1, 100);
    if (i < length - 1)
    {
        Console.Write($"{array[i]}, ");
    }
    else
    {
        Console.Write($"{array[i]}");
    }
}
