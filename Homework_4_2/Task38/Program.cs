// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.


double [] array = new double [8];
double max = 0;
double min = 0;
double dif = 0;
int i = 0;

for (i = 0; i < array.Length; i++)
   array[i] = new Random().NextDouble() * 100;

i = 0;
max = array[i];
min = array[i];

while (i < array.Length)
    if (array[i] > max)
    {
        max = array[i];
        i++;
    }
    else
    {
        i++;
    }

i = 0;

while (i < array.Length)
    if (array[i] < min)
    {
        min = array[i];
        i++;
    }
    else
    {
        i++;
    }

dif = (max - min);

Console.WriteLine($"Массив из 8 псевдослучайных вещественных чисел: ");
for (i = 0; i < array.Length; i++)
   Console.Write($"{array[i]}, ");

Console.WriteLine($" ");

Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {dif}");
