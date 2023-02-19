// Задача 21 Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.


Console.WriteLine("Введите координаты первой точки");
Console.WriteLine("координата по оси Х");
double xA = double.Parse(Console.ReadLine()!);
Console.WriteLine("координата по оси Y");
double yA = double.Parse(Console.ReadLine()!);
Console.WriteLine("координата по оси Z");
double zA = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты второй точки");
Console.WriteLine("координата по оси Х");
double xB = double.Parse(Console.ReadLine()!);
Console.WriteLine("координата по оси Y");
double yB = double.Parse(Console.ReadLine()!);
Console.WriteLine("координата по оси z");
double zB = double.Parse(Console.ReadLine()!);
double c = Math.Sqrt(Math.Pow(xA - xB,2) + Math.Pow(yA - yB,2) + Math.Pow(zA - zB,2));
Console.Write($"расстояние между точками {c:f2}");

