/* Доп. задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */

int numberOne = Input("Введите первое число: ");
int numberTwo = Input("Введите первое число: ");

if (numberOne * numberOne == numberTwo)
{
    Console.WriteLine("Да! Число: " + numberTwo + " является квадратом числа: " + numberOne);
}
else
{
    Console.WriteLine("Нет! Число: " + numberTwo + " не является квадратом числа: " + numberOne);
}

int Input(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}
