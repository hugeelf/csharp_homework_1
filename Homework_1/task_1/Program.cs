/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
int numberFirst = new int();
int numberSecond = new int();

Console.WriteLine("Введите первое число");
numberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
numberSecond = Convert.ToInt32(Console.ReadLine());

if (numberFirst > numberSecond){
    Console.WriteLine($"<Большее число {numberFirst}, а меньшее число {numberSecond}");
}
else if (numberFirst < numberSecond){
    Console.WriteLine($"<Меньшее число {numberFirst}, а большее число {numberSecond}");
}
else {
    Console.WriteLine("Числа равны");
}