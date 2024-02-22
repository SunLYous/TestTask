using TestTask;
using Xunit;

namespace Test;

public class Test
{
    [Fact]
    void CalculateAreaCircle_ShouldReturnTrue_WhenWriteValidRadius()
    {
        const double radius = 2;
        var circle = new Circle(radius);
        double area = circle.CalculateArea();
        Assert.Equal(radius * radius * Math.PI, area);
    }

    [Fact]
    void CalculateAreaCircle_ShouldReturnException_WhenWriteInValidRadius()
    {
        const double radius = -2;
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }

    [Fact]
    void CalculateAreaTriangle_ShouldReturnTrue_WhenWriteValidSides()
    {
        const double firstSide = 3;
        const double secondSide = 4;
        const double thirdSide = 5;
        const double expectedArea = 6;
        var triangle = new Triangle(firstSide, secondSide, thirdSide);
        var area = triangle.CalculateArea();
        Assert.Equal(expectedArea, area);
    }

    [Fact]
    void CalculateAreaTriangle_ShouldReturnException_WhenWriteInValidSides()
    {
        const double firstSide = 3;
        const double secondSide = 4;
        const double thirdSide = -2;
        Assert.Throws<ArgumentException>(() => (new Triangle(firstSide, secondSide, thirdSide)));
    }
    
    [Fact]
    void CalculateAreaTriangle_ShouldReturnException_WhenWriteInValidTriangle()
    {
        const double firstSide = 3;
        const double secondSide = 4;
        const double thirdSide = 10;
        Assert.Throws<ArgumentException>(() => (new Triangle(firstSide, secondSide, thirdSide)));
    }

    [Fact]
    void CheckRightTriangle_ShouldReturnTrue_WhenWriteValidRightTriangle()
    {
        const double firstSide = 3;
        const double secondSide = 4;
        const double thirdSide = 5;
        var triangle = new Triangle(firstSide, secondSide, thirdSide);
        Assert.True(triangle.IsRightTriangle());
    }
    
    [Fact]
    void CheckRightTriangle_ShouldReturnFalse_WhenWriteInValidRightTriangle()
    {
        const double firstSide = 3;
        const double secondSide = 4;
        const double thirdSide = 6;
        var triangle = new Triangle(firstSide, secondSide, thirdSide);
        Assert.False(triangle.IsRightTriangle());
    }
}