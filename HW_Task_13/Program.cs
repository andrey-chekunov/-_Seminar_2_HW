/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Write("Input your number: ");
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
