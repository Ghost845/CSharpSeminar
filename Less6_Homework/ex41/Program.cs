// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Выберите количество символов, которое хотите ввести: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [m];
void FillArray(int[] array)
{
    for(int i = 0; i < m; i++)
    {
        Console.Write("Введите любое число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    for(int j = 0; j < m; j++)
    {
        Console.Write($"{array[j]} ");
    }
}

FillArray(arr);
PrintArray(arr);

int sum = 0;
for(int i = 0; i < m; i++)
{
    if(arr[i] > 0)
    {
        sum ++;
    }
}
Console.Write($"-> {sum}");