/*
Задача 8: Напишите программу, которая на вход принимает число (N), а 
на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int number = new int();
Console.WriteLine("Введите число");
number = Convert.ToInt32(Console.ReadLine());

if (number > 1)
{
    int count = 2;
    while (count <= number)
    {
        Console.WriteLine(count);
        count = count + 2;
    }
}
else if (number < -1)
{
    int count = 0;
    while (count >= number)
    {
        Console.WriteLine(count);
        count = count - 2;
    }
}
else if (number == 0|number == -1) {
    Console.WriteLine("0");
}
else {
    Console.WriteLine($"В следующий раз попробуйте указать другое число, так как четных чисел в промежутке от 0 до {number} нет");
}
