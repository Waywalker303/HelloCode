//Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

int n = Input("Введите число: ");
int i =1;
int result = 1;
string number ="";
while(n>=i)
{
    result= Quadro(i);
    number = number + Convert.ToString(result)+ ",";
    i++;
}
Console.WriteLine(number);

int Quadro(int a)
{
    return a * a;
}


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

/* решение преподавателя
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= n)
{
    int result = Quadro(count);
    count = count + 1;
    Console.Write($"{result}, ");
}
Console.WriteLine(Quadro(n));

int Quadro (int a)
{
    return a * a;
}
*/