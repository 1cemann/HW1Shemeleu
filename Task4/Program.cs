//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


using System;

Console.Clear();
Console.WriteLine("Введите первое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int value2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int value3 = Convert.ToInt32(Console.ReadLine());

int max = value1;

if (value1 > max ) max = value1;
if (value2 > max ) max = value2;
if (value3 > max ) max = value3;

Console.Write("Максимальным числом из введённых будет ");
Console.WriteLine(max);