// Программа, которая принимает на вход
// трехзначное число и на выходе показывает
// вторую цифру этого числа

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = number % 100;
Console.WriteLine(digit / 10);