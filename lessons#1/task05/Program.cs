// Напишите программу, которая принимает на вход
// Трехзначное число и на выходе показывает последнюю цифру
// этого числа
//456 -> 6
//782 -> 2
//918 -> 8

//Вход
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int lastDigit = number%10;
//выход
Console.WriteLine($"Последняя цифра {lastDigit}");
