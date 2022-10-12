// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Ввведите число N больше единицы");
int N = int.Parse(Console.ReadLine()!);
int M = 1;

if (N < 1)
{
    Console.WriteLine("Вы ввели некорректное число N");
}
else
{
    while (M < N)
    {
        Console.Write($"{Math.Pow(M, 3)}, ");
        M ++;
    }
Console.Write($"{Math.Pow(M, 3)} ");
}
