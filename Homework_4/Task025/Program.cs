/*

Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B.


*/

double Exponentiation(double numA, double numB)
{
    // numA = Math.Pow(numA, numB); // возведение numA в степень numB
    // return numA;
    double number = numA;

    for (int i = 1; i < numB; i++)
    {
        numA = numA * number;
    }
    return numA;

}
Console.WriteLine("Введите число А");
double numA = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Введите число B");
double numB = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"Число {numA} в степени {numB} = {Exponentiation(numA, numB)}");