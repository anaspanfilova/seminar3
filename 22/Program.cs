// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void Kvadrat(int a)
{
    for (int i = 1; i <= a; i++) 
    {
        Console.Write($"{i*i}");
        if (i != a)
        {
            Console.Write(", ");
        }
    }
}
Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
Kvadrat(x);