// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите начальное число промежутка: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число промежутка: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int x = SumNumbers(m, n, sum);

int SumNumbers(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.WriteLine($"Сумма натуральных элементов равна: {sum}");
        return sum;
    }
    SumNumbers(m, n - 1, sum);
    return m;
}