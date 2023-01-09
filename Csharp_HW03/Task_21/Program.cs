//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("X1");
int x1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y1");
int y1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z1");
int z1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("X2");
int x2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y2");
int y2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z2");
int z2= Convert.ToInt32(Console.ReadLine());
double rasst = Math.Round(Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2)),2);
Console.WriteLine($"Расстояние в пространсве равно {rasst}"); 