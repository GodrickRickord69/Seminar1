﻿/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

int max;
Console.Write("Введите число a ");
int a = int.Parse(Console.ReadLine()!);
max = a;

Console.Write("Введите число b ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите число c ");
int c = int.Parse(Console.ReadLine()!);

if( b > max )
{
    max = b; 
}
else if( max > c )
{
    max = c;
}
else
{
Console.WriteLine("Max: "+max.ToString());
};