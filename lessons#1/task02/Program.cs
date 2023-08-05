// Напишите программу, которая будет выдвать
// Дни недели по заданному номеру

// 3-> Среда
// 5-> Пятница

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите номер от 01 до 07 номер недели");
        string num = Console.ReadLine();

        if (num == "1")Console.WriteLine("Понедельник");
        if (num == "2") Console.WriteLine("Вторник");
        if (num == "3") Console.WriteLine("Среда");
        if (num == "4") Console.WriteLine("Четверг");
        if (num == "5") Console.WriteLine("Пятница");
        if (num == "6") Console.WriteLine("Суббота");
        if (num == "7") Console.WriteLine("Воскресенье");

        else Console.WriteLine("Error - 440");
    }
}