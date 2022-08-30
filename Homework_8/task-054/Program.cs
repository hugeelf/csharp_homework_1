// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

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

int[,] SortingArrayCols(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
    return array;

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
int[,] sortedArray = SortingArrayCols(array);
PrintArray(sortedArray);
