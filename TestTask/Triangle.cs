namespace TestTask;

public class Triangle : ITriangle
{
    public Triangle(double thirdSide, double secondSide, double firstSide)
    {
        if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
        {
            throw new ArgumentException("Side < 0");
        }

        if (!IsTriangle(firstSide, secondSide, thirdSide))
        {
            throw new ArgumentException("triangle does not exist");
        }

        ThirdSide = thirdSide;
        SecondSide = secondSide;
        FirstSide = firstSide;
    }

    public double FirstSide { get; }
    public double SecondSide { get; }
    public double ThirdSide { get; }

    public double CalculateArea()
    {
        var perimeter = (FirstSide + SecondSide + ThirdSide) / 2;
        return Math.Sqrt(perimeter * (perimeter - FirstSide) * (perimeter - SecondSide) * (perimeter - ThirdSide));
    }

    public bool IsRightTriangle()
    {
        var sides = new List<double> { FirstSide, SecondSide, ThirdSide };
        sides.Sort();
        return (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)) == Math.Pow(sides[2], 2);
    }

    private bool IsTriangle(double thirdSide, double secondSide, double firstSide)
    {
        return firstSide + secondSide > thirdSide &&
               firstSide + thirdSide > secondSide &&
               secondSide + thirdSide > firstSide;
    }
}