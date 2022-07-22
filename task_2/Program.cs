//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int x1 = Location ("x", "a");
int y1 = Location ("y", "a");
int z1 = Location ("z", "a");
int x2 = Location ("x", "b");
int y2 = Location ("y", "b");
int z2 = Location ("z", "b");

int Location(string position, string placement)
{
    Console.Write($"Введите координаты {position} точка {placement}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Equation(double x1, double x2, double y1, double y2, double z1, double z2)
{

  return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
                  
}

double LineLength =  Math.Round (Equation(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {LineLength}");