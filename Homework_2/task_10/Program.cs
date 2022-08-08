/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int ShowMeASecondDigit(int number)
{
    int result = (number / 10) % 10;
    return result;
}

int IsItAThreeDigitNumber(int number)
{
    if (Math.Abs(number) >= 100 & Math.Abs(number) <= 999)
    {
        return 1;
    }
    else
    {
        return 0;
    }
}
Console.WriteLine("Введите трехзначное число число");
int number = Convert.ToInt32(Console.ReadLine());
int switcher = IsItAThreeDigitNumber(number);
int secondDigit = ShowMeASecondDigit(Math.Abs(number));
if (switcher == 1)
{
    Console.WriteLine(secondDigit);
}
else
{
    Console.WriteLine($"Число {number} не является трехзначным");
}
