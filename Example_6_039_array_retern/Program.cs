//Задача 39 разворот массива 2 варианта

int[] numbers = {1, 2, 3, 4, 5, 6};

for (int i = 0; i < numbers.Length / 2; i++)
{
    int temp = numbers[i];
    numbers[i] = numbers[numbers.Length - 1 - i];
    numbers[numbers.Length - 1 - i] = temp;
}

for(int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}

/*Второй вариант разворота (через второй массив)

int[] numbers = {1, 2, 3, 4, 5};
int[] tempArray = new int[numbers.Length];

for(int i = 0; i < numbers.Length; i++)
{
    tempArray[i] = numbers[numbers.Length - 1 - i];
}

numbers = tempArray;

for(int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}
*/