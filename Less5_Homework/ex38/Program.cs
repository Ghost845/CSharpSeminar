// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

Console.Write("Введите минимальное значение массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int b = Convert.ToInt32(Console.ReadLine());

double[] array(int z)
{
    double[] newA = new double [z];
    for(int i = 0; i < z; i++)
    {
        newA[i] = new Random().Next(a, b + 1);
        Console.Write(newA[i] + " ");
    }
    return newA;
}
Console.Write("Введите количество элементов массива: ");
int z = Convert.ToInt32(Console.ReadLine());
double[] newArr = array(z);

double maxN = newArr[1];
double minN = newArr[1];

for(int i = 0; i < z; i++)
{
    if(newArr[i] > maxN)
    {
        maxN = newArr[i];
    }
    else if(newArr[i] < minN)
    {
        minN = newArr[i];
    }
}
Console.Write($"-> {maxN - minN}");