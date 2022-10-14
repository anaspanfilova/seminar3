// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Формула расчета расстояния (нужно построить вектор)

Console.Clear();
Console.Write("Введите X координаты отрезка A: ");
int ax = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты отрезка A: ");
int ay = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z координаты отрезка A: ");
int az = int.Parse(Console.ReadLine()!);

Console.Write("Введите X координаты отрезка B: ");
int bx = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты отрезка B: ");
int by = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z координаты отрезка B: ");
int bz = int.Parse(Console.ReadLine()!);
double Dist(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result;
    // result = Math.Sqrt ((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1))
    result = Math.Sqrt (Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2));

    // result = Math.Round(result,2);
       return result;
}
Console.WriteLine($"Длина отрезка разва {Dist(ax,ay,az,bx,by,bz):f2}");

