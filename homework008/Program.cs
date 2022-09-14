// /Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
double  x1, x2, y1, y2, z1, z2;
Console.WriteLine("Enter x coordinate of first point");
x1 =double.Parse(Console.ReadLine());
Console.WriteLine("Enter y coordinate of first point");
y1 =double.Parse(Console.ReadLine());
Console.WriteLine("Enter z coordinate of three point" );
z1 =double.Parse(Console.ReadLine());
Console.WriteLine("Enter x coordinate of second point");
x2 =double.Parse(Console.ReadLine());
Console.WriteLine("Enter y coordinate of second point");
y2 =double.Parse(Console.ReadLine());
Console.WriteLine("Enter z2 coordinate of three point" );
z2 = double.Parse(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));

Console.WriteLine(result);

