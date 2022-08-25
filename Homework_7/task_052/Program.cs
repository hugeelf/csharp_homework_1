﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
double FindAverage(int[,] array)
{
    double average = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {

        for (int i = 0; i < array.GetLength(0); i++)
        {
            average = (average + array[i, j]);
        }
        average = average / array.GetLength(0);
        Console.Write($"{Math.Round(average, 2)}; ");
    }
    return average;
}
Console.WriteLine("введите количество строк");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("введите количество столбцов");
int m = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[,] array = new int[n, m];

FillArrayRandomNumbers(array);
PrintArray(array);
FindAverage(array);