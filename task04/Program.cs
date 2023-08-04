


//Напишите программу которая на вход принимает
//Одно число (N), а на выходе показывает все целые
//числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1 , 2, 3, 4"
//2 -> "-2, -1, 0, 1, 2"

Console.Writeline("Введите целое число");
int number = Conver.ToInt32(Console.ReadLine());
int count = -number;
while (Coynt <= number)
{
    console.Write($"{count}");
    count++;
}
