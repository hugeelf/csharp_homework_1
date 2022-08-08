/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

string IsItAHoliday (int dayOfWeek)
{string answer="Хмм";
    if(dayOfWeek<1 || dayOfWeek>7)
    {
        answer =  "В неделе всего 7 дней";
    }
    else if(dayOfWeek>5 && dayOfWeek<=7)
    {
        answer = "Этот день выходной";
    }
    else if (dayOfWeek>0 && dayOfWeek<=5)
    {
        answer = "Этот день не выходной";
    }
    return answer;
}



Console.WriteLine("Введите номер дня недели");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

string holiday = IsItAHoliday(dayOfWeek);
Console.WriteLine(holiday);
