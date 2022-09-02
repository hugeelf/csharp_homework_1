// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N от большего к меньшему.
// M = 1; N = 5. -> ""5, 4, 3, 2, 1""
// M = 4; N = 8. -> ""8, 7, 6, 5, 4""


string PrintNumbers (int m, int n)
{
    if (n==m) return $"{m}";
    else return $"{n}" + PrintNumbers(m, n-1);
}




int m = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.Write(PrintNumbers(m,n));