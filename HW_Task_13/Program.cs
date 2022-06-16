/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Write("Input your number: ");
int n = Convert.ToInt32(Console.ReadLine());
int N = n / 10;
int res = N % 10;
if (n < 99)
{
    Console.Write("Third number is missing.");
}
else
{
    while (n > 999)
    {
        n = n / 10;
    }
    res = n % 10;
    Console.Write("Third number is :" + res);
}
