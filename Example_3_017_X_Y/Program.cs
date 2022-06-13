/*Напишите программу, котрая принимает на вход координаты (X и Y), 
причём X !=0 и Y != b и выдаёт номер четверти плосксти в которой находиться точка
*/
int x = Input("Введите координату x: ");
int y = Input("Введите координату y: ");

if(x == 0 || y == 0)
{
    Console.WriteLine("x и y не могут быть равны 0");
    return;
}

int result = GetNumberQuarter(x, y);
Console.WriteLine($"{result} четверть");

int GetNumberQuarter(int x, int y)
{
    int result = 0;
    if(x > 0 && y > 0)
    {
        result = 1;
    }
    if(x < 0 && y > 0)
    {
        result = 2;
    }
    if(x < 0 && y < 0)
    {
        result = 3;
    }
    if(x > 0 && y < 0)
    {
        result = 4;
    }
    return result;
}


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
