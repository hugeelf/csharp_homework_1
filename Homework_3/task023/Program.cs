/*
Задача 23

Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/
int qubeOneToN(int n, int index, int answer)
{
    while (index <= n)
    {
        answer = index * index * index;
        Console.WriteLine(answer);
        index++;
    }
    return index;
}
int index = 1;
int answer = 0;
int qubes = 0;
Console.WriteLine("Введите число, для которого необходимо построить таблицу кубов:");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
qubes = qubeOneToN(n, index, answer);