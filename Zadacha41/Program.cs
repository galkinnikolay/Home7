// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


double[] array = new double[5];
for (int i = 0; i < array.Length; i++)
{
    double number = new Random().Next(-1000, 1001) + new Random().NextDouble(); // 8 + 0.22 = 8.22
    array[i] =  Math.Round(number, 2); 
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}

double result = count;
Console.WriteLine(" ");
Console.WriteLine($"Количество положительных элементов: {result}");