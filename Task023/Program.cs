﻿// Задача 23

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



Console.WriteLine($"Введите число N");
double N = Convert.ToInt32(Console.ReadLine());
for (int count = 1; count <= N; count++)
{
   double X = Math.Pow(count, 3);
   Console.WriteLine(X);
}

