/* Задача 40: Напишите программу, которая принимает на вход три числа и 
проверяет, может ли существовать треугольник с сторонами такой длины. */



int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int a = Input("Введите первое число: ");
int b = Input("Введите второе число: ");
int c = Input("Введите третье число: ");

if ( a < b+c || b < a+c || c < b+c) 
{
     Console.Write("Треугольник возможен");
}
else Console.Write("Треугольник НЕвозможен");

