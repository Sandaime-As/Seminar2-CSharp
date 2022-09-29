/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
using static System.Console;
Clear();
void ThirdNumber(int num1)
 { 
    int a0;
    if (num1 <= 99)
    {
        WriteLine("Третьей цифры нет, введите трёхзначное число");
    }
    else
    {
    while (num1>1000)
    {
    a0=num1 % 10;
    num1= (num1-a0)/10;
    }
        int a1 = num1 % 10;
        WriteLine($"Результат: {a1}");
    }
}
WriteLine("Введите число: ");
int a = Convert.ToInt32(ReadLine()!);
ThirdNumber(a);