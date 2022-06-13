/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.Write("Enter a number indicating the day of the week: ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());
if (dayOfWeek == 6 || dayOfWeek == 7)
{
    Console.WriteLine("This day of the week is a day off.");
}
else if (dayOfWeek > 1 && dayOfWeek < 6)
{
    Console.WriteLine("This day of the week is a working day.");
}
else
{
    Console.WriteLine("Enter the number corresponding to the day of the week.");
}
