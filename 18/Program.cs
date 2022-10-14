// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти от 1 до 4: ");
int x = int.Parse(Console.ReadLine()!);
if (x == 1)
{
    Console.WriteLine("x > 0, y > 0");
}
else if (x == 2)
{
    Console.WriteLine("x < 0, y > 0");
}
else if (x == 3)
{
    Console.WriteLine("x < 0, y < 0");
}
else if (x == 4)
{
    Console.WriteLine("x > 0, y < 0");
}
else
{
    Console.WriteLine("Введите другое число от 1 до 4");
}