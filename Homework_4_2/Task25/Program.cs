// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

Console.Write("Введите целое положительное число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число В, обозначающее степень, в которую необходимо будет возвести число А: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = 1;
int i = 1;

while (i <= b)
{
    result = result * a;
    i++;
}

Console.WriteLine($"{a} возведенное в {b} степень ровняется: {result}");