//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

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