// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


int [] array = new int [8];
int chet = 0;
int i = 0;

for (i = 0; i < array.Length; i++)
   array[i] = new Random().Next(100,1000);

i = 0;

while (i < array.Length)
    if ((array[i] % 2) == 0)
    {
        chet++;
        i++;
    }
    else
    {
        i++;
    }

Console.WriteLine($"Массив из 8 псевдослучайных целых чисел от 100 до 1000: ");
for (i = 0; i < array.Length; i++)
   Console.Write($"{array[i]}, ");

Console.WriteLine($" ");

Console.WriteLine($"Количество четных чисел в данном масиве: {chet}");
