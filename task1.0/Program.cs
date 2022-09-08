// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

Console.WriteLine("Ввести координаты x точка 1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввести координаты y точка 1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввести координаты z точка 1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввести координаты x точка 2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввести координаты y точка 2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввести координаты z точка 2");
int z2 = Convert.ToInt32(Console.ReadLine());

double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = 0;
    distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + (Math.Pow(z2-z1, 2)));
    return distance;

}

Console.WriteLine ( $" Distance: { GetDistance (x1, y1, z1, x2, y2, z2)} ");