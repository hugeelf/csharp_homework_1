// : Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{result[i]} ");
    }
    return result;
}

double FindMax(double[] array)
{
    double result = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (result < array[i])
        {
            result = array[i];
        }
    }
    return result;
}
double FindMin(double[] array)
{
    double result = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (result > array[i])
        {
            result = array[i];
        }
    }
    return result;
}
double Dif(double maxNumber, double minNumber)
{
    double result = maxNumber - minNumber;
    return result;
}
double[] array = GetArray(10, -99, 100);
double maxNumber = FindMax(array);
double minNumber = FindMin(array);
Console.WriteLine();
Console.WriteLine($"Разность между максимальным значением в массиве {maxNumber} и минимальным значением {minNumber} = {Dif(maxNumber, minNumber)}");
