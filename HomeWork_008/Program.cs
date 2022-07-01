// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double PointDistance (double x1, double y1, double z1, double x2, double y2, double z2)
{
double xLine = x2 - x1;
double yLine = y2 - y1;
double zLine = z2 - z1;

double distanceQ = xLine*xLine + yLine*yLine + zLine* zLine;

double result = Math.Sqrt(distanceQ);

return result;
}

Console.Write("Input your X coordinates for A: ");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your Y coordinates for A: ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your Z coordinates for A: ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your X coordinates for B: ");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input your Y coordinates for B ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input your Z coordinates for B: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double res = PointDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(res);