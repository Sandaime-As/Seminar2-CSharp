/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
using static System.Console;
Clear();
WriteLine("Введите число: ");
int num()
{
    int num = Convert.ToInt32(ReadLine()!);
    int a0=num/10;
    int a1=a0%10;
    return a1;
}
WriteLine($"Второе число из трехзначного = {num()}");