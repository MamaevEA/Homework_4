// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите целое число от 1 до N для нахождения кубов всех чисел: ");
int n = Convert.ToInt32(Console.ReadLine());

int count = 1;

while (count <= n)
{
    Console.WriteLine($" {count} -> {Math.Pow(count, 3)}");
    count++;
}