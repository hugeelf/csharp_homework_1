// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] FillArray(int rowNumber, int columnNumber)
{
    int[,] result = new int[rowNumber, columnNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < columnNumber; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

int[] SummsOfRows(int[,] array)
{
    int[] result = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summOfRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summOfRow = summOfRow + array[i, j];
        }
        result[i] = summOfRow;
    }
    return result;
}

void RowWithMinimumSumm(int[] array)
{
    int minimum = array[0];
    int rowCounter = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minimum)
        {
            minimum = array[i];
            rowCounter = i + 1;
        }
    }
    Console.WriteLine($"Строка с наименьщей суммой элементов {rowCounter} и значение суммы {minimum}");
}

void PrintArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write($"{newArray[i, j]} ");
        }
        Console.Write("]");
        Console.WriteLine();

    }

    Console.WriteLine();
}

Console.WriteLine($"введите количество строк");
int rowNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"введите количество столбцов");
int columnNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[,] array = FillArray(rowNumber, columnNumber);
PrintArray(array);
RowWithMinimumSumm(SummsOfRows(array));