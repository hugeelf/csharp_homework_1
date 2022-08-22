// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//y = k1 * x + b1, 
//y = k2 * x + b2

// y-y = (k1*x+b1)-(k2*x+b2)
//b1 - b2 + k1*x - k2*x
//b1 - b2 + (k1-k2)*x=0
//2-4+(5-9) * x = 0
//-2-4x=0
//-2=4x
//x=-2/4
// x = (b1-b2) / (k1-k2)

// y = k2 * x + b2
// y = 9*-0.5 +4
double FirstCoordinate(double bOne, double kOne, double bTwo, double kTwo)
{
    double result = (bTwo - bOne) / (kOne - kTwo);
    // Console.Write($" b1 = {bOne} k1 = {kOne} b2 = {bTwo} k2 = {kTwo}");
    return result;

}
double SecondCoordinate(double x, double kTwo, double bTwo)
{
    double result = kTwo*x + bTwo;
    return result;
}

Console.WriteLine($"введите b1");
double bOne = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"введите k1");
double kOne = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"введите b2");
double bTwo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"введите k2");
double kTwo = Convert.ToDouble(Console.ReadLine());
double x = FirstCoordinate(bOne, kOne, bTwo, kTwo);
double y = SecondCoordinate(x, kTwo, bTwo);
Console.WriteLine($"Прямые пересекаются в точке {x},{y}");