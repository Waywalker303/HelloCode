/*Задача 26  Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5*/

Console.WriteLine("Enter your number: ");
int numb = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (numb >= 10)
{
    numb = numb / 10;
    count ++;
} 
Console.WriteLine(count);
