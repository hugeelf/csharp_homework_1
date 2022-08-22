// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int [] GetUserNumbers(int countOfNumbers)
{   int [] result = new int [countOfNumbers];
    for(int i=0; i<countOfNumbers; i++)
    {
        Console.WriteLine($"введите {i+1} число");
        result[i]=Convert.ToInt32(Console.ReadLine());

    }
    return result;
}

int CountOfPositive(int []userNumbers)
{
    int result = 0;
    for (int i = 0; i<userNumbers.Length; i++)
    {
        if (userNumbers[i]>0)
        {
            result+=1;
        }
    }
    return result;
}


Console.WriteLine($"Сколько чисел вы хотите ввести?");
int countOfNumbers = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int [] userNumbers = GetUserNumbers(countOfNumbers);
// Console.WriteLine(String.Join("", userNumbers));
Console.WriteLine($"Чисел, больше 0 - {CountOfPositive(userNumbers)}");
