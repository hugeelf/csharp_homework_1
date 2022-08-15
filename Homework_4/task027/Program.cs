/*

Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.

*/

int SummOfDigits(int number, int numberLength)
{
    int sum = 0;
    for (int i = 0; i <= numberLength; i++)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}
int GetTheNumberLength(int number)
{
    int result = 0;
    while (number / 10 != 0)
    {
        result = result + 1;
        number = number / 10;
    }
    return result;
}
Console.WriteLine("Введите число ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int numberLength = GetTheNumberLength(number);
Console.WriteLine($"Сумма цифр числа {number} = {SummOfDigits(number, numberLength)}");