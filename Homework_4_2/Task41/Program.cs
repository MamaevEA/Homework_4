// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Сколько чисел будете вводить (М): ");
int m = Convert.ToInt32(Console.ReadLine());

int i = 0;
int [] array = new int [m];
int plus = 0;

while (i < m)
{ 
    Console.Write("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    array[i] = x;
    i++;
}

i = 0;

while (i < m)
    if (array[i] > 0)
    {
        plus++;
        i++;
    }
    else i++;

Console.WriteLine($"Количество положительных чисел: {plus}");
