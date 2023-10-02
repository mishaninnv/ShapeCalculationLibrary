using ShapeCalculationLibrary.Interfaces;

namespace ShapeCalculationLibrary.Models;

public class Circle : IArea
{
    private double _radius;

    /// <summary>
    /// Создание фигуры - круг.
    /// </summary>
    /// <param name="radius">Радиус круга.</param>
    /// <exception cref="ArgumentException">Выбрасывается если радиус меньше 0.</exception>
    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Number should be non-negative.");
        }
        _radius = radius;
    }

    double IArea.CalculateArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}