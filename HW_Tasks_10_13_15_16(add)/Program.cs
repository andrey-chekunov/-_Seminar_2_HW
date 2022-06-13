//Данный файл содержит решение всех задач из Домашнего Задания.

/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 

Console.Write("Input your three-digit number: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
int ab = threeDigitNumber % 100;
int b = ab / 10;
Console.Write("Your second number in a three-digit number is: " + b);


/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

/* Console.Write("Input your number: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 99 && N < 1000)
{
    int n = N % 10;
    Console.Write("Third number is: " + n);
}
else if (N > 0 && N < 100)
{
    int n = N % 10;
    Console.Write("Third number is missing.");
}
else
{
    if (N > 1000 && N < 10000)
    {
        int n = (N / 10) % 10;
        Console.Write("Third number is: " + n);
    }
    else if (N > 10000 && N < 100000)
    {
        int n = (N / 100) % 10;
        Console.Write("Third number is: " + n);
    }
}


/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

/* Console.Write("Enter a number indicating the day of the week: ");
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


/*Доп. задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */

/* Console.Write("Enter first number: ");
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
}*/