// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(99, 1000);
int digit = (number / 10) % 10;

Console.WriteLine(number);

Console.WriteLine(digit);

