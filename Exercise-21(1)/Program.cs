Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Z: ");
int z1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Z: ");
int z2Coordinate = Convert.ToInt32(Console.ReadLine());

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
    return distance;
}
double result = Distance(x1Coordinate,y1Coordinate,z1Coordinate,x2Coordinate,y2Coordinate,z2Coordinate);
double dRound = Math.Round(result,2,MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками равно {dRound}");
