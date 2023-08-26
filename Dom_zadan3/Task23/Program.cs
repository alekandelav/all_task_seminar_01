//Задача 23
//Напишите программу, которая принимает 
//на вход число (N) и выдаёт 
//таблицу кубов чисел от 1 до N.
//5 ->
//1 | 1
//2 | 8
//3 | 27
//4 | 64
//5 | 125

Console.WriteLine("Введите число, чтобы вывести таблицу кубов чисел от 1 до N.");
int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"| {i*i*i} ");
    
}

// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

