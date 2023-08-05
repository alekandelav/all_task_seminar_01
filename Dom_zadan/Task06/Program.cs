// Напишите программу, которая на вход 
//принимает число и выдаёт, 
//является ли число чётным 
//(делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Является ли чесло четным? : ");
int num = int.Parse(Console.ReadLine());
int remain = num % 2;
if (remain == 0)
{
    Console.WriteLine("Число " + num + " четное?");
    Console.WriteLine("Четное!");
}
else
{
    Console.WriteLine("Число " + num + " четное?");
    Console.WriteLine("Не четное!");
}

