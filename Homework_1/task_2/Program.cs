﻿/*
Задача 4: Напишите программу, которая принимает на вход три числа и 
выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int numberOne, numberTwo, numberThree;

Console.WriteLine("Введите первое число");
numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
numberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
numberThree = Convert.ToInt32(Console.ReadLine());
int max = numberOne;
if (max<numberTwo){
    max=numberTwo;
}
if (max<numberThree){
    max=numberThree;
}
Console.WriteLine($"Наибольшее число {max}");