/*Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
using static System.Console;
Clear();
void DayOfWeek(int a)
{
if (a > 5 && a < 8) 
    {
    WriteLine("да");
    }
else if (a<=5)
    {
    WriteLine("нет");
    }
else 
    {
    WriteLine("Введите число от 1 до 7");
    }
}
Write("Введите число: ");
int day = Convert.ToInt32(ReadLine()!);
DayOfWeek(day);