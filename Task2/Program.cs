using System;

Console.Clear();
Console.WriteLine("Введите первое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int value2 = Convert.ToInt32(Console.ReadLine());

if(value1>value2)
{
    Console.Write("Число ");
    Console.Write(value1);
    Console.Write(" Больше чем число ");
    Console.Write(value2);
}
else
{
    Console.Write("Число ");
    Console.Write(value1);
    Console.Write(" Меньше чем число ");
    Console.Write(value2);
}