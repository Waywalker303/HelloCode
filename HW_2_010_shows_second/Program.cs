﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

//int number = new Random().Next(100, 1000);
//Console.WriteLine(number);
Console.WriteLine("Введи трёхзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = number % 100 / 10;

if((number.ToString().Length) == 3)
    {
    Console.WriteLine(secondDigit);
    }
else
    {
    Console.Write("Ошибка! Введите трёхзначное число!");
    }  