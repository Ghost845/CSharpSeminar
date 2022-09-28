// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите координату x для первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y для первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z для первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x для второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y для второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z для второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int[] A = new int[] {x1, y1, z1};
int[] B = new int[] {x2, y2, z2};
double d = Math.Sqrt(Math.Pow(B[0] - A[0], 2) + Math.Pow(B[1] - A[1], 2) + Math.Pow(B[2] + A[2], 2));
Console.Write($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2}) -> {Math.Round(d, 2)}");
// double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Console.Write($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2}) -> {Math.Round(d, 2)}");
