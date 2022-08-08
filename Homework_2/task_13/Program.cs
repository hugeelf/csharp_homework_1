/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int GetLengthOfNumber(int number, int numberLength)
{ 
    while(number!=0)
    {
       number=number/10;
       numberLength++;
    }
    return numberLength;
}

int FindThirdDigit(int number, int numberLength)
{
    while(numberLength!=3)
    {
        number=number/10;
        numberLength=numberLength-1;
    }
    return number%10;
}


Console.WriteLine("Введите число число");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int numberLength = 0;
int thirdDigit;

numberLength = GetLengthOfNumber(number, numberLength);

if(numberLength>=3)
{
    thirdDigit = FindThirdDigit(number,numberLength);
    Console.WriteLine(thirdDigit);
}
else 
{
    Console.WriteLine("Данное число не содержит третьей цифры");
}