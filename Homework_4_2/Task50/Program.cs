// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] mass = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

Console.WriteLine($"Введите номер строки");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите номер столбца");
int y = Convert.ToInt32(Console.ReadLine());

if (x < mass.GetLength(0) && y < mass.GetLength(1))
{
    Console.WriteLine($"{mass[x,y]}");
}
else Console.WriteLine($"такого элемента в массиве нет");

