// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();
Console.Write("Введите x: ");
int x = int.Parse(Console.ReadLine()!);

Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine()!);

if (x > 0)
{
    if (y > 0)
    {
Console.WriteLine("Первая черверть");
    }
    else
    {
        Console.WriteLine("Четвертая черверть");
    }
}
else
{
    if (y > 0)
        {
    Console.WriteLine("Вторая черверть");
        }
    else 
    {
    Console.WriteLine("Третья черверть");
    }
}