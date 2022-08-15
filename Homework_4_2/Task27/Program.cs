// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите целое положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int summ = 0;

while (n > 0)
{
    summ = summ + (n % 10);
    n = n / 10;
}

Console.WriteLine($"Сумма цифр составляет: {summ}");