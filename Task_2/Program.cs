// Программа, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 99)
    Console.WriteLine("Третьей цифры нет");
else if (number <= 999)
    Console.WriteLine(number % 10);
else
{
    while (number > 999)  
    {  
      number = number / 10;
    }
    Console.WriteLine(number % 10);
}