double Line3D (int xa, int ya, int za, int xb, int yb, int zb)
{
    double length3D = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
    return length3D;
}
Console.Write("Input coord x of A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coord y of A: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coord z of A: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coord x of B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coord y of B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coord z of B: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double dist = Line3D(x1, y1, z1, x2, y2, z2);
Console.Write($"Length of line between A and B = {dist:f2}");