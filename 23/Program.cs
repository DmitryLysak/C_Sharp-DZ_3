// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// * при N < 0, нужно вывести от N до -1


Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
if (number > 0)
{
int count = 1;
while (count <= number)
{
    Console.Write (Math.Pow(count,3));
    if (count != number) Console.Write(", ");
    count ++;
}}
else
{
int count = - 1;
while (count >= number)
{
    Console.Write (Math.Pow(count,3));
    if (count != number) Console.Write(", ");
    count --;
}}