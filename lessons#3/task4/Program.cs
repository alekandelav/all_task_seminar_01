double Distance(int x1, int y1, int x2, int y2)
{
    int side1 = x1 - x2;
    int side2 = y1 - y2;
    double distance = Math.Sqrt(side1 * side1 + side2 * side2);
    return distance;
}

Console.WriteLine("Введите координаты 1 точки");
Console.Write("X: ");
int xCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты 2 точки");
Console.Write("X: ");
int xCoordinate2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(xCoordinate1, yCoordinate1, xCoordinate2, yCoordinate2);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);

Console.WriteLine(resultRound);
