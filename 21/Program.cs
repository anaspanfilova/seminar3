// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Формула расчета расстояния (нужно построить вектор)

{
    double result;
    // result = Math.Sqrt ((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1))
    result = Math.Sqrt (Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2));

    // result = Math.Round(result,2);
       return result;
}

Console.Clear();
Console.Write("Введите X координаты отрезка A: ");
int ax = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты отрезка A: ");
int ay = int.Parse(Console.ReadLine()!);

Console.Write("Введите X координаты отрезка B: ");
int bx = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты отрезка B: ");
int by = int.Parse(Console.ReadLine()!);
double Dist(int x1, int y1, int x2, int y2)

Console.WriteLine($"Длина отрезка разва {Dist(ax,ay,bx,by):f2}");