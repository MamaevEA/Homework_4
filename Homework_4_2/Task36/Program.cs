// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).


int [] array = new int [8];
int summ = 0;
int i = 0;

for (i = 0; i < array.Length; i++)
   array[i] = new Random().Next(-100,100);

i = 1;

while (i < array.Length)
summ = summ + array[i];
i = i + 2;


Console.WriteLine($"Массив из 8 псевдослучайных целых чисел от -100 до 100: ");
for (i = 0; i < array.Length; i++)
   Console.Write($"{array[i]}, ");

Console.WriteLine($" ");

Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях (индексах): {summ}");