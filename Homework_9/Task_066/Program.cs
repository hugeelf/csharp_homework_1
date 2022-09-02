// // Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// четных чисел натуральных элементов в 
// промежутке от M до N.
// M = 1; N = 15 -> 56
// M = 4; N = 8. -> 18




int SummOfNumbers(int m, int n)
{
    if (n < m) return 0;
    else if (m % 2 != 0)
    {
        m = m + 1;
        return m + SummOfNumbers(m + 2, n);
    }
    else
    {
        return m + SummOfNumbers(m + 2, n);
    }
}



int m = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(SummOfNumbers(m, n));