/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
bool isCordCorrect(string[] coordPoint, ref Point point)
{    
    if (coordPoint.Length != 3)
        return false;

    int number = 0;
    for(int i = 0; i < 3; i++)
    {
        bool tryParse = int.TryParse(coordPoint[i], out number);

        if (!tryParse)
            return false;

        switch (i)
        {
            case 0:
                point.X = number;
                break;
            case 1:
                point.Y = number;
                break;
            case 2:
                point.Z = number;
                break;            
        }        
    }

    return true;
}

Point Point1 = new Point(), Point2 = new Point();

Console.Write("Введите координаты точки A (x,y,z): ");
string[] coordPoint1 = (Console.ReadLine() ?? String.Empty).Split(',');

if (!isCordCorrect(coordPoint1, ref Point1))
{
    Console.WriteLine("Ошибка ввода координаты точки A.\r\nВыполнение программы будет остановлено.");
    return;
}

Console.Write("Введите координаты точки B (x,y,z): ");
string[] coordPoint2 = (Console.ReadLine() ?? String.Empty).Split(',');

if (!isCordCorrect(coordPoint2, ref Point2))
{
    Console.WriteLine("Ошибка ввода координаты точки B.\r\nВыполнение программы будет остановлено.");
    return;
}

double distance = Math.Sqrt(Math.Pow(Point2.X - Point1.X, 2) + Math.Pow(Point2.Y - Point1.Y, 2) + Math.Pow(Point2.Z - Point1.Z, 2));

Console.WriteLine($"A ({Point1.X},{Point1.Y},{Point1.Z}); B ({Point2.X},{Point2.Y},{Point2.Z}) -> {Math.Round(distance, 2)}");


struct Point
{
    public int X;
    public int Y;
    public int Z;
}














