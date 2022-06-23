
/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10 */

// решение 1

int number = Input("Введите число: ");
string digit = String.Empty;

while(number  > 0)
{
    digit = number % 2 + digit;
    number /= 2;
}

Console.Write(digit);

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

// решение 2 через цикл

