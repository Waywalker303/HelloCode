/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int N = Input("Введите число: ");
int[] numbers = new int[N];


if (N > 2)
{
    numbers[0] = 0;
    numbers[1] = 1;
    for (int i = 2; i < numbers.Length; i++)
    {
        numbers[i] = numbers[i - 1] + numbers[i - 2];
    }
    Write($"Если N = 5 -> ");
    PrintArray(numbers);
}
else if (N == 1)
{
    Write(numbers[0]);
}
else if (N == 2){ 
    Write(0 + " " + 1);
}
else Write("Ошибка");


/* // вариант 2

Console.Write("Введите, сколько чисел нужно вывести: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
if(n > 0)
{
    array[0] = 0;
}
if(n > 1)
{
    array[1] = 1;
}

for(int i = 2; i < array.Length; i++)
{
    array[i] = array[i - 1] + array[i - 2];
}

for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
*/