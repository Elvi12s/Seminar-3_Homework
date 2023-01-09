//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Число N ");
int N= Convert.ToInt32(Console.ReadLine());
int[] array= new int[N];
for(int i=0;i<N;i++)
{array[i]=(int)Math.Pow(i+1,3);
Console.Write($"{array[i]} ");}