/*Задача 13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, 
что третьей цифры нет. 

645 -> 5 78 -> третьей цифры нет 32679 -> 6
*/

int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int MakeArray(int a, int b)
{
int result = 0;
if (b < 3)
{
    Console.Write("Третьей цифры нет : ");
}
    else
    {
    int d = 1;
    for (int i = b; i > 3; i--)
    {
     d = d * 10;
    }
    result = (a / d) % 10;
    }
return result;
}

