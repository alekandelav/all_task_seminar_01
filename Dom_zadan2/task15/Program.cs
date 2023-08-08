/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("день " + a + " - Выходной день. ");
        }
        else
        {
            Console.Write("день " + a + " - Рабочий день. ");
        }
    }
    else
    {
        Console.Write(" Вы не можете ввести число больше, так как в неделе - 7 дней");
    }
    return(" ( Если вам надо узнать день недели выходной он или нет, попробуйте ввести заново, перезапустив программу. )");
}