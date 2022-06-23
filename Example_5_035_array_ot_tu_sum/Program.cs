/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

int[] array = new int[5]; 
int b = 0;
FillArrayRandomNumbers(array);
PrintArray(array);


for(int i = 0; i < array.Length; i++)
{
     if(array[i] >= 10 && array[i] < 100 )
        {
        b++;
        
        }
}
if (b == 0)
{

    Console.Write("НЕТ");
}
else
{
    Console.Write("ДА ");
    Console.Write(b);
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FillArrayInputNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Input("Число:");
    }
}
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 200);
    }
}
