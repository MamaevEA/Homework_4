// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите целое положительное трехначное число: ");
int x = Convert.ToInt32(Console.ReadLine());

if ((x > 99) && (x < 999)) Console.WriteLine($"Вторая цифра числа {x} является: {(x % 100) / 10}");
else Console.WriteLine("Введено некорректное число");
