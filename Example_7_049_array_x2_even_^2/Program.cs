/*Задача 49: Задайте двумерный массив. Найдите элементы, у которых 
оба индекса нечётные, и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4*/

int m = Input("m=");
int n = Input("n=");
int[,] number = new int[m, n];

FillSeccondsArrayNumbers(number);
PrintSeccondArray(number);
Console.WriteLine();

for (int i = 0; i < number.GetLength(0); i++)
{
    for (int j = 0; j < number.GetLength(1); j++)
    {
        if (i % 2 != 0 && j % 2 != 0)
        {
            number[i,j]*=number[i,j];
        }
            
    }
}
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
