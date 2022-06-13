/*Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).*/

int ch = Input("Введите четверть: ");
    if(ch==1)
    {
        
        Console.WriteLine($"x=0....{int.MaxValue}, y=0....{int.MaxValue} ");
    }
    else if(ch==2)
    {
        
        Console.WriteLine($"x={int.MinValue}....0, y=0....{int.MaxValue} ");
    }
    else if(ch==3)
    {
        
        Console.WriteLine($"x={int.MinValue}....0, y={int.MinValue}....0 ");
    }
    else if(ch==4)
    {
        
        Console.WriteLine($"x=0....{int.MaxValue}, y={int.MinValue}....0 ");
    }
    else
    {
        Console.WriteLine("нет такой четверти");
    }

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
