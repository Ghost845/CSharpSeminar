Console.Clear();
int[] array = new int[5];
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int rev = 0;
while (num > 0);
{
    rev = rev * 10 + num % 10;
    num = num / 10;
}
if (rev == num)
{
    Console.WriteLine("Введённое число - палиндром");
}
else
{
    Console.WriteLine("Введённое число - не палиндром");
}