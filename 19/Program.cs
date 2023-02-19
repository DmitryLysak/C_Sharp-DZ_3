// Задача 19 Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.


Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
if (num < 9999 || num > 99999)
    Console.WriteLine("Число не пятизначное");
else
if (num / 10000 == num % 10 && num / 1000 == num / 1000)
    Console.WriteLine("Число - полином");
else
    Console.WriteLine("Число - не полином");