namespace TestTask;

public class Circle : IShare
{
    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("radius < 0");
        }

        Radius = radius;
    }

    public double Radius { get; }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}