// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.Write("Введите максимальное число для промежутка: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 0) Console.WriteLine("Число должно быть натуральным!");
else
{
    int count = 2;
    Print(n, count);
    Console.Write(1);
}
void Print(int n, int count)
{
  if (count > n) return;
  Print(n, count + 1);
  Console.Write(count + ", ");
}