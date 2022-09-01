// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillArray (int[,] matr)
{
     for (int i = 0; i < matr.GetLength(0); i++)
     {
         for (int j = 0; j < matr.GetLength(1); j++)
         {
             matr[i,j] = new Random().Next(1,10);
         }
     }
 }

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine($"Введите количество строк массива");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите количество столбцов массива");
int y = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[x, y];

void Summ(int[,] matr)
{
    int i = 0;
    int j = 0;
    int summ = 0;
    while (j < y)
    {
        i = 0;
        summ = 0;
        while (j < y && i < x)
        {
            summ = summ + matr[i,j];
            i++;
        }
        Console.Write($"{summ / matr.GetLength(0)} ");
        j++;
    }
}

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine("Среднее арифметическое чисел в столбцах равно: ");

Summ(matrix);