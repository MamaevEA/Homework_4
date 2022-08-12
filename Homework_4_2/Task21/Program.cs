// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координату Х точки А ");
int xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Х точки B ");
int xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Х точки C ");
int xc = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y точки А ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Х точки B ");
int yb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Х точки C ");
int yc = Convert.ToInt32(Console.ReadLine());

double line = Math.Sqrt(Math.Pow((xa - ya),2) + Math.Pow((xb - yb),2) + Math.Pow((xc - yc),2));

Console.Write("Расстояние между точками: ");
Console.WriteLine(Math.Round (line, 2));