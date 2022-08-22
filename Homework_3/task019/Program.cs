/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

*/
string IsItAPalindrome(int number)
{   string answer = " не палиндром";
    int ourNumber = number;
    int reversedNumber=0;
    while (number>0)
    {
        reversedNumber = reversedNumber*10 + number%10;
        number = number/10;
    }
    if (reversedNumber == ourNumber)
    {
        answer = " палиндром";
    }
    return answer;
}
int getNumberLength(int number)
{
    int index = 0;
    while (number != 0)
    {
        number = number / 10;
        index++;
    }
    return index;
}
Console.WriteLine("Введите число,:");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int numberLength = getNumberLength(number);
string isAPalindrome="";

if(numberLength>=2)
{
    isAPalindrome = IsItAPalindrome(number);
    Console.WriteLine($"Число {number}{isAPalindrome}");
}
else
{
    Console.WriteLine($"Число {number} слишком мало, попробуйте увеличить колличество знаков");
}
