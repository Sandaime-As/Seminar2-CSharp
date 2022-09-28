// Доп задача: вывести числа в обратном порядке из трехзначного числа
using static System.Console;

Clear();
int number = new Random().Next(100,1000);
WriteLine(number);

int a0 = number%10;
int a2 = number/100;
int a1 = (number-(a2*100+a0));


int result = a0*100+a1+a2;

//WriteLine($"{a2}{a0}");
WriteLine(result);