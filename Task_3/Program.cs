// Программа, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7 || number < 1)
    Console.WriteLine("Такого дня недели не существует");
else if (number < 6)
    Console.WriteLine("Будний день");
else if (number <= 7)
    Console.WriteLine("Выходной день");
