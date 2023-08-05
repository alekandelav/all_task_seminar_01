// Напишите программу, которая 
//принимает на вход три числа и выдаёт
// максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите три числа");
Console.WriteLine("какое из них имеет максимальное значение.");

Console.Write("Введите 1 число: ");
int max1 = int.Parse(Console.ReadLine());
Console.Write("Введите 2 число: ");
int max2 = int.Parse(Console.ReadLine());
Console.Write("Введите 3 число: ");
int max3 = int.Parse(Console.ReadLine());
int maxNum = 0;

if (max1 > maxNum) maxNum = max1;
if (max2 > maxNum) maxNum = max2;
if (max3 > maxNum) maxNum = max3;
Console.Write("максимальное число из этих чисел : " + maxNum);