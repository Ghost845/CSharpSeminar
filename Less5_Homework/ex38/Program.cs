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
        newA[i] = new Random().Next(a, b);
        Console.Write(newA[i] + " ");
    }
    return newA;
}
Console.Write("Введите количество элементов массива: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.Write(array());

double maxN = newA[1];
double minN = newA[1];

// double[] max()
// {
//     while()


//     return maxNum;
// }