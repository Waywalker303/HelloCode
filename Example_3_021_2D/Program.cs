/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int  x1 = Input("Введите координату x1: ");
int  y1 = Input("Введите координату y1: ");

int  x2 = Input("Введите координату x2: ");
int  y2 = Input("Введите координату y2: ");

int  x =x1-x2;
Console.WriteLine(x);
int y =y1-y2;
Console.WriteLine(y);

double result=Math.Sqrt(x*x+y*y);

Console.WriteLine(result);


/*второе решение от преподавателя
int x1 = Input("Введите координату X1: ");
int y1 = Input("Введите координату Y1: ");
int x2 = Input("Введите координату X2: ");
int y2 = Input("Введите координату Y2: ");

int distanceX = CalculateDistance(x1, x2);
int distanceY = CalculateDistance(y1, y2);

double distance = Math.Sqrt(Quadro(distanceX) + Quadro(distanceY));

Console.WriteLine("Расстояние между точками " + distance);

int Quadro(int a)
{
    return a * a;
}

int CalculateDistance(int a, int b)
{
    return a - b;
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

*/