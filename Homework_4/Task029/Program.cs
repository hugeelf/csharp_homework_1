/*

Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.

*/
// Массив, заполненный рандомными числами от 0 до 999
/*void RandomArray(int[] array, int arrayLength)
{   Console.Write("[ ");
    for (int i=0; i < arrayLength; i++)
    {
        array[i] = new Random().Next(0, 1000);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
} 

Console.WriteLine("Введите размер массива");
int arrayLength = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] array = new int[arrayLength];
//int[] array =  {};
RandomArray(array, arrayLength);
*/

//сами вносим значения в массив

void ManualyAddElementsToArray(int[] array, int arraySize)
{
    for (int i = 0; i < arraySize; i++)
    {
        Console.WriteLine("Введите значение элемента массива'");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("[ ");
    for (int i = 0; i < arraySize; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

Console.WriteLine("Введите размер массива");
int arraySize = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] array = new int[arraySize];
ManualyAddElementsToArray(array, arraySize);