// Напишите программу, которая на вход
// принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число (N): ");

int num = int.Parse(Console.ReadLine());
int even = 2;

Console.WriteLine ("ВЫ ВИДИТЕ ЭТИ ЧИСЛА от 1 до N");

while (num >= even)
{
    Console.Write(even + " ");
    even = even + 2;
}
