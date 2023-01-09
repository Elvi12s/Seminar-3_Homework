//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Console.WriteLine("Введите число");
int N= Convert.ToInt32(Console.ReadLine());
int t1=N/(int)Math.Pow(10,4);
int t2=N/(int)Math.Pow(10,3)-(N/(int)Math.Pow(10,4))*10;
int t3=N/(int)Math.Pow(10,2)-(N/(int)Math.Pow(10,3))*10;
int t4=(N%(int)Math.Pow(10,2))/10;
int t5=N%(int)Math.Pow(10,1);
int round= t5*(int)Math.Pow(10,4)+t4*(int)Math.Pow(10,3)+t3*(int)Math.Pow(10,2)+t2*10+t1;
if (round==N) Console.WriteLine("Полиндром");
else  Console.WriteLine("Нет");