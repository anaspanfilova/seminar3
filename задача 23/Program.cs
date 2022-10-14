// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void Kub(int a)
{
    for (int i = 1; i <= a; i++) 
    {
        Console.Write($"{i*i*i}");
        if (i != a)
        {
            Console.Write(", ");
        }
    }
}
Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
Kub(x);