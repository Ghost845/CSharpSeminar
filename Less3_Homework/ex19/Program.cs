// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = n;
int preLast = n;
if ( n > 99999 || n < 10000)
{
    Console.Write("Введённое число не пятизначное");
}
else
{
    while (i > 99)
    {
        i = i / 10;
    }
    while (preLast > 99)
    {
        preLast = preLast % 100;
    }
    if ( n / 10000 == n % 10 & i % 10 == preLast / 10)
    {
        Console.Write($"{n} -> да");
    }
    else
    {
        Console.Write($"{n} -> нет");
    }
}

// string a = Convert.ToString(Console.ReadLine());
// if (a[0] == a[4] && a[1] == a[3])
// {
//     Console.WriteLine("Палиндром");
// }
// else
// {
//     Console.WriteLine("Не палиндром");
// }
// P.S. Стринги круче)