/*Доп. задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */

Console.Write("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());
int aSquare= a*a;
int bSquare = b*b;
if (aSquare==b || bSquare==a)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}