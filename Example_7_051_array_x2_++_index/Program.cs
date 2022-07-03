/*Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

int m = Input("m=");
int n = Input("n=");
int[,] number = new int[m, n];

FillSeccondsArrayNumbers(number);
PrintSeccondArray(number);
Console.WriteLine();
int sum = 0;

for (int i = 0; i < number.GetLength(0); i++)
{
    for (int j = 0; j < number.GetLength(1); j++)
    {
        if (i == j)
        {
            if (i > 0 && j > 0)
            {
                Console.Write($"+{number[i, j]}");
            }
            else
            {
                Console.Write($"{number[i, j]}");
            }
            sum = sum + number[i, j];
        }
    }
}

Console.Write($"={sum}");
Console.WriteLine();

PrintSeccondArray(number);
void PrintSeccondArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }

}


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}


void FillSeccondsArrayNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    }
}
