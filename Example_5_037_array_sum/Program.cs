/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/


int size = Input("Введи размер: ");
int[] array = new int[size];
int[] arr2;
int s = size;
int size2;
FillArrayRandomNumbers(array);
PrintArray(array);
if(size%2 == 0)
{
size2=size/2;
arr2= new int[size2];

}
else
{
size2=(size/2)+1;
arr2= new int[size2];
arr2[size2-1]=array[size2-1];
}
for(int i = 0; i < array.Length/2; i++)
    {
     arr2[i]=array[i]*array[s-1];
     s--;
    }
PrintArray(arr2);

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
        array[i] = new Random().Next(1, 5);
    }
}
