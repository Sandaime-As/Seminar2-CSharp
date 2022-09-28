/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.*/
using static System.Console;
Clear();
WriteLine("Введите число: ");
int num1=int.Parse(ReadLine()!);
if (num1 == 0)
{
    WriteLine("Не лезь к нулю!");
    return; 
}
int div1=num1%7;
int div2=num1%23;
if (div1==0 || div2==0)
{
    WriteLine($"{num1} кратно 7 и 23");
}
else
{
    WriteLine($"{num1} не кратно 7 и 23");
}