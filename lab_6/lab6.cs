using System;

abstract class Shape
{
    public abstract double Volume(); // Абстрактний метод для обчислення об'єму
}

class Point3D : Shape
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

    public bool HasIntegerCoordinates()
    {
        return X % 1 == 0 && Y % 1 == 0 && Z % 1 == 0;
    }

    public bool IsInFirstOctantOfSpace()
    {
        return X > 0 && Y > 0 && Z > 0;
    }

    public override double Volume()
    {
        // Об'єм для точки завжди буде 0
        return 0;
    }

    ~Point3D()
    {
        Console.WriteLine("Об'єкт Point3D було видалено.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point3D point = new Point3D(3, 5, 2);
        Console.WriteLine($"Точка має цілі координати: {point.HasIntegerCoordinates()}");
        Console.WriteLine($"Точка знаходиться в першому октанті: {point.IsInFirstOctantOfSpace()}");

        double volume = point.Volume();
        Console.WriteLine($"Об'єм точки: {volume}");
    }
}
