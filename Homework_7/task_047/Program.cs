// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10; //чтобы получить число с запятой, разделим число рандома на 10
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[  ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.WriteLine("введите количество строк");
int rows = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("введите количество столбцов");
int columns = Math.Abs(Convert.ToInt32(Console.ReadLine()));
double[,] array = new double[rows, columns];
FillArrayRandomNumbers(array);
PrintArray(array);
