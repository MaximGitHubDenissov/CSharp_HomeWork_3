// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (можно решить через строку, а можно математически)

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine ("Введити пятизначное число");
String Num = Console.ReadLine ()!;

if (Num.Length == 5)
{
    int A = Convert.ToInt32(Num[0]);
    int B = Convert.ToInt32(Num[1]);
    int C = Convert.ToInt32(Num[3]);
    int D = Convert.ToInt32 (Num[4]);
    if (A == D && B == C)
    {
        Console.WriteLine ("Ваше число является палиндромом!");
    }
    else
    {
        Console.WriteLine ("Ваше число не является палиндромом!");
    }
}
else 
{
    Console.WriteLine ("Вы ввели не пятизначное число!");
}
