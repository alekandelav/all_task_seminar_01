// See https://aka.ms/new-console-template for more information

string RangeCoordinates(int quart)
{
    if (quart ==1) return "x > 0 ; y > 0";
    if (quart ==2) return "x < 0 ; y > 0";
    if (quart ==3) return "x < 0 ; y < 0";
    if (quart ==4) return "x > 0 ; y < 0";
    return null;
}
Console.WriteLine("Введите координаты точки");
int quarter = Convert.ToInt32(Console.ReadLine());

string rangeCoordinates=RangeCoordinates(quarter);
string result = rangeCoordinates != null 
? rangeCoordinates
                    : " Введены некорректные координаты";
Console.WriteLine(result);