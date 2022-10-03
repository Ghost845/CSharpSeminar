// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] newArray(int z)
{
    int[] array = new int [z];
    for ( int i = 0; i < z; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i] + " ");
    }
    return array;
}

Console.Write("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = newArray(num);
int sum = 0;

for(int i = 0; i < num; i++)
{
    if(arr[i] % 2 == 0)
    {
        sum++;
    }
}

Console.Write($"-> {sum}");