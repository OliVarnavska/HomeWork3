﻿// Задача 19

// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.WriteLine($"Введите пятизначное число");
int N = Convert.ToInt32(Console.ReadLine());
int a = N % 10;
int b = N / 10;
int c = b % 10;
int d = b / 100;
int i = d % 10;
int f = N / 10000;
if ((a == f) && (c == i)) 
{
    Console.WriteLine($"Введенное число - палиндром");
}
else
{
    Console.WriteLine($"Введенное число - не палиндром");
}

