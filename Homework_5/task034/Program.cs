// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{result[i]} ");
    }
    return result;
}
int CountingEven(int [] array)
{   int result = 0;
    foreach (int i in array)
    {
        if (i%2==0)
        {
            result++;
        }
    }
    return result;
}

int [] array = GetArray(10, 100,1000);
Console.WriteLine($"Количество четных чисел в массиве = {CountingEven(array)}");