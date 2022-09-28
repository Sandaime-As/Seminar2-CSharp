//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

using static System.Console;
Clear();
int number = new Random().Next(10, 99 + 1);
WriteLine(number);
int a0 = number % 10;
int a1 = number / 10;
if (a0 > a1)
{
    WriteLine($"Максимальная цифра = {a0}");
}
else
{
    WriteLine($"Максимальная цифра = {a1}");
}
/* Можно сократить код вводя переменные сразу в условие, например:

if(number%10>number/10)
{
    WriteLine($"Максимальная цифра = {number%10}");
}
else
{
    WriteLine($"Максимальная цифра = {number/10}");
}*/