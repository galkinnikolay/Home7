// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


double[] array = new double[5];
for (int i = 0; i < array.Length; i++)
{
    double number = new Random().Next(-10, 10) + new Random().NextDouble(); // 8 + 0.22 = 8.22
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



// Console.Write("Введите количество элементов массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] Array = new int[m];

// void mas(int m)
// {
// for (int i = 0; i < m; i++)
// {
// Console.WriteLine($"Введите {i+1} элемент массива ");
// Array[i] = Convert.ToInt32(Console.ReadLine());
// }

// }

// int kol(int[] Array)
// {
// int i=0;
// int sum = 0;
// while (i < Array.Length)
// {
// if(Array[i]>0)
// sum = sum + 1;
// i = i + 1;
// }
// return sum;
// }

// mas(m);
// Console.Write($"n Чисел больше нуля: {kol(Array)}");