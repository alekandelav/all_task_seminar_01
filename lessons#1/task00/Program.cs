﻿//Напишите программу которая

//1. На вход принимает число и выдает его в квадрат
// число умноженное на само себя

//Например:
// 4-> 16
//-3 -> 9
// -7 -> 49


Console.WriteLine ("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");


//$ - интерполция