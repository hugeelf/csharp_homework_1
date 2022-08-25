// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.(на вход именно поступает позиция элемента, можете разбить на две переменные или прописать в одну строку и конвертировать в два числа, комментарии в конце семинара по этой задаче)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет





void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10) ;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[  ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.Write("  ]");
        Console.WriteLine("");
    }
}

Console.WriteLine("введите номер строки");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("введите номер столбца");
int m = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[,] array = new int[5, 5];
FillArrayRandomNumbers(array);


if (n > array.GetLength(0) || m > array.GetLength(1))
{
    Console.WriteLine("элемента нет");
}
else
{
    Console.WriteLine($"значение {n} строки и {m} столбца = {array[n - 1, m - 1]}");
}
PrintArray(array);
