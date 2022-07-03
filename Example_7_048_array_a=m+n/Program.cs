/*Задача 48: Задайте двумерный массив размера m на n,
 каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5 */

int m = Input("m=");
int n = Input("n=");
int[,] number=new int[m, n];

FillSeccondsArrayNumbers(number);
PrintSeccondArray(number);

void PrintSeccondArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " "); 
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
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
           array[i,j] =i+j; 
        }
    }
}

