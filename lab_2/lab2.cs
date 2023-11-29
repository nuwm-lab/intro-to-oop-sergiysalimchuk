using System;

class Point
{
    private int x;
    private int y;
    private int z;

    public Point(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public bool AreCoordinatesInteger()
    {
        return (x % 1 == 0) && (y % 1 == 0) && (z % 1 == 0);
    }

    public bool IsInFirstOctant()
    {
        return (x > 0) && (y > 0) && (z > 0);
    }
}

class Program
{
    static void Main()
    {
    
        Point point = new Point(3, 4, 5);

      
        bool areInteger = point.AreCoordinatesInteger();
        Console.WriteLine($"Чи всі координати цілочисельні: {areInteger}");

 
        bool isInFirstOctant = point.IsInFirstOctant();
        Console.WriteLine($"Чи точка знаходиться в першому октанті: {isInFirstOctant}");
    }
}
