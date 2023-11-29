using System;

public class Point3D
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public Point3D(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public bool AreCoordinatesInteger()
    {
        return X % 1 == 0 && Y % 1 == 0 && Z % 1 == 0;
    }

    public bool IsInFirstOctant()
    {
        return X > 0 && Y > 0 && Z > 0;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Point3D point = new Point3D(3, 5, 2);

        if (point.AreCoordinatesInteger())
        {
            Console.WriteLine("Координати точки - цілі числа.");
        }
        else
        {
            Console.WriteLine("Координати точки - не цілі числа.");
        }

        if (point.IsInFirstOctant())
        {
            Console.WriteLine("Точка знаходиться в першому октанті.");
        }
        else
        {
            Console.WriteLine("Точка не знаходиться в першому октанті.");
        }
    }
}
