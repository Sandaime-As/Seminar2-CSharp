/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.*/
using static System.Console;

Clear();
WriteLine("Введи первое число: ");
int number1 = int.Parse(ReadLine()!);
WriteLine("Введи второе число: ");
int number2 = int.Parse(ReadLine()!);

if (number2 == 0)
{
WriteLine(" 0 не является квадратом ни какого числа");
return;
}

if (number1 == 0)
{
WriteLine(" 0 не является квадратом ни какого числа");
return;
}

if (number2>number1)
{
int temp = number1;
number1 = number2;
number2 = temp;
}

double sqrt = Math.Sqrt(number1); //sqrt - квадратный корень, sqr - возведение в квадрат

if (sqrt == number2)
{
WriteLine($"{number1} квадрат {number2}");
}
else
{
WriteLine($"{number1} не является квадратом {number2}");
}