// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

Console.Write("Введите минимальное значение массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] array(int z)
{
    int[] newArr = new int[z];
    for(int i = 0; i < z; i++)
    {
        newArr[i] = new Random().Next(a, b + 1);
        Console.Write(newArr[i] + " ");
    }
    return newArr;
}

Console.Write("Введите количество элементов массива: ");
int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение массива: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение массива: ");
// int b = Convert.ToInt32(Console.ReadLine());
int[] arr = array(x);
int sum = 0;
for(int i = 0; i < x; i++)
{
    if(i % 2 == 1)
    {
        sum +=arr[i];
    }
}
Console.WriteLine($"-> {sum}");