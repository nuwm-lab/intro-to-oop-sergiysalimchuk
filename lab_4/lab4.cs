using System;
public class PolarCoordinates
{
    private double radius;
    private double angle;

    public PolarCoordinates(double radius, double angle)
    {
        this.radius = radius;
        this.angle = angle;
    }

    public void SetPolarCoordinates(double radius, double angle)
    {
        this.radius = radius;
        this.angle = angle;
    }

    public void SetCartesianCoordinates(double x, double y)
    {
        this.radius = Math.Sqrt(x * x + y * y);
        this.angle = Math.Atan2(y, x);
    }

    public void ConvertToCartesian(out double x, out double y)
    {
        x = radius * Math.Cos(angle);
        y = radius * Math.Sin(angle);
    }
}

public class CylindricalCoordinates : PolarCoordinates
{
    private double height;

    public CylindricalCoordinates(double radius, double angle, double height) : base(radius, angle)
    {
        this.height = height;
    }

    public void SetCylindricalCoordinates(double radius, double angle, double height)
    {
        base.SetPolarCoordinates(radius, angle);
        this.height = height;
    }

    public void SetCartesianCoordinates(double x, double y, double z)
    {
        base.SetCartesianCoordinates(x, y);
        this.height = z;
    }

    public void ConvertToCartesian(out double x, out double y, out double z)
    {
        base.ConvertToCartesian(out x, out y);
        z = height;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        PolarCoordinates polarCoord = new PolarCoordinates(5.0, Math.PI / 4);
        CylindricalCoordinates cylindricalCoord = new CylindricalCoordinates(3.0, Math.PI / 3, 7.0);

        double x, y, z;

        polarCoord.ConvertToCartesian(out x, out y);
        Console.WriteLine($"Полярні координати перетворено в декартові: x = {x}, y = {y}");

        cylindricalCoord.ConvertToCartesian(out x, out y, out z);
        Console.WriteLine($"Циліндричні координати перетворено в декартові: x = {x}, y = {y}, z = {z}");

        Console.ReadLine();
    }
}
