using System;

class Point3D
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
 public Point3D()
        Console.WriteLine("Об'єкт Point3D буде знищений.");
    }
}
    public bool HasIntegerCoordinates()
    {
        return X % 1 == 0 && Y % 1 == 0 && Z % 1 == 0;
    }

    public bool IsInFirstOctantOfSpace()
    {
        return X > 0 && Y > 0 && Z > 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point3D[] points = new Point3D[]
        {
            new Point3D(3, 5, 2),
            new Point3D(-1, 4, 6),
            new Point3D(2, -3, 8),
            new Point3D(7, 9, 1),
            new Point3D(0, 0, 0)
        };

        int countIntegerCoordinatesAndInFirstOctant = 0;

        foreach (Point3D point in points)
        {
            if (point.HasIntegerCoordinates() && point.IsInFirstOctantOfSpace())
            {
                countIntegerCoordinatesAndInFirstOctant++;
            }
        }

        Console.WriteLine($"Кількість точок з цілими координатами в першому октанті: {countIntegerCoordinatesAndInFirstOctant}");
    }
}
