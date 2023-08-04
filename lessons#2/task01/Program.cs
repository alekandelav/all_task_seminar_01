//11. Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого
//числа.
//456 -> 46
//782 -> 72
//918 -> 98

int number = new Random().Next(10, 1000); // 99 + 1
Console.WriteLine($"Случайное число из диапазона 10-999 -> {number}");

int TwoNumbers = TwoNumbers(number);
Console.WriteLine(TwoNumbers);


int TwoNumbers (int num)
{
int firstDigit = number / 10;
int secondDigit = number % 10;
int result = firstDigit * 10 + lastDigit;
return result;
}