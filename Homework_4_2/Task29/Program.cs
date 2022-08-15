// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int [] array = new int [8];

for (int i = 0; i < array.Length; i++)
   array[i] = new Random().Next(0,100);

Console.WriteLine($"Массив из 8 псевдослучайных целых чисел от 0 до 100: [{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]}]");