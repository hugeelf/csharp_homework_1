// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
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
int SumOfOdd(int[] array)
{   int result = 0;
    for (int i = 0; i<array.Length; i=i+2)
    {
        result=result+array[i];
    }
    return result;
}
int [] array = GetArray(10,-999,1000);
Console.WriteLine($"Сумма чисел, на нечетных позициях массива = {SumOfOdd(array)}");