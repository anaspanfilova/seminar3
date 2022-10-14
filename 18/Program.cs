// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();
Console.Write("Введите номер четверти от 1 до 4: ");
int x = int.Parse(Console.ReadLine()!);
switch (x)
{
    case 1:
    {
        Console.WriteLine("x > 0 y > 0");
        break;
    }
    case 2:
    {
        Console.WriteLine("x < 0 y > 0");
        break;
    }
    case 3:
    {
        Console.WriteLine("x < 0 y < 0");
        break;
    }
        case 4:
    {
        Console.WriteLine("x > 0 y < 0");
        break;
    }
        default:
    {
        Console.WriteLine("Введите другое число в промежутке от 1 до 4");
        break;
    }
}