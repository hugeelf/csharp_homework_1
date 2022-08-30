// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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

int [,] MatrixMultiplication (int [,] matrixFirst, int [,] matrixSecond)
{
    int [,] multiMatrix = new int [matrixFirst.GetLength(0), matrixSecond.GetLength(1)];
    for (int i =0; i<matrixFirst.GetLength(1); i++)
    {
        for (int j=0; j<matrixSecond.GetLength(0); j++)
        {
           for (int k = 0; k<matrixSecond.GetLength(0); k++)
           {
            multiMatrix [i,j] = multiMatrix[i,j] + (matrixFirst[i,k]* matrixSecond [k,j]);
            // Console.WriteLine(multiMatrix[i,j]);
           }
        }
    }
    return multiMatrix;

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
Console.WriteLine();
int[,] matrixFirst = FillArray(rowNumber, columnNumber);
int[,] matrixSecond = FillArray(rowNumber, columnNumber);
int[,] multiMatrix = MatrixMultiplication (matrixFirst, matrixSecond);
// IsItPossible(matrixFirst, matrixSecond);
PrintArray(matrixFirst);
PrintArray(matrixSecond);
PrintArray(multiMatrix);