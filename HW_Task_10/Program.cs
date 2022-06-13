/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.Write("Input your three-digit number: ");
int threeDigitNumber = Convert.ToInt32(Console.Read());
int ab = threeDigitNumber % 100;
int b = ab / 10;
Console.Write("Second number in your three-digit number is: " + b);