//  ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] FillArray(int rowNumber, int columnNumber, int thirdNumber)
{
    int[,,] result = new int[rowNumber, columnNumber, thirdNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < columnNumber; j++)
        {
            for (int k = 0; k < thirdNumber; k++)
            {
                result[i, j, k] = new Random().Next(100, 980) / 10 + new Random().Next(1, 2);
            }
        }
    }
    return result;
}

void PrintArray(int[,,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {

        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write("[ ");

            for (int k = 0; k < newArray.GetLength(2); k++)
            {

                Console.Write($"{newArray[i, j, k]} ");
            }
            Console.Write("]");
            Console.WriteLine();
        }


    }
    Console.WriteLine();
}

void PrintArrayWithIndexes(int[,,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {

        for (int j = 0; j < newArray.GetLength(1); j++)
        {

            for (int k = 0; k < newArray.GetLength(2); k++)
            {
                Console.Write("[ ");
                Console.Write($"{newArray[i, j, k]} ]");
                Console.Write($" индексы элемента [{i}, {j}, {k}] ");
            }
            Console.WriteLine();
        }


    }

    Console.WriteLine();
}

Console.WriteLine($"введите количество строк");
int rowNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"введите количество столбцов");
int columnNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine($"введите количество третье измерение");
int thirdNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine();
int[,,] newArray = FillArray(rowNumber, columnNumber, thirdNumber);
PrintArray(newArray);
PrintArrayWithIndexes(newArray);