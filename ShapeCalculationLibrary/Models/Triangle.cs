using ShapeCalculationLibrary.Interfaces;

namespace ShapeCalculationLibrary.Models;

public class Triangle : IArea
{
    private List<double> _sides;

    /// <summary>
    /// Создание фигуры - треугольник.
    /// </summary>
    /// <param name="side1">Первая сторона.</param>
    /// <param name="side2">Вторая сторона.</param>
    /// <param name="side3">Третья сторона.</param>
    /// <exception cref="ArgumentException">Выбрасывается если одна или несколько сторон меньше 0, либо сумма меньших сторон равна (либо меньше) большей стороне.</exception>
    public Triangle(double side1, double side2, double side3)
    {
        _sides = new List<double>(new[] { side1, side2, side3 });
        _sides.Sort();
        if (_sides.Any(x => x <= 0))
        {
            throw new ArgumentException("Number should be non-negative.");
        }
        else if (_sides.Max() >= _sides.Sum() - _sides.Max())
        {
            throw new ArgumentException("Degenerate triangle - a triangle whose vertices all lie on the same line.");
        }
    }

    double IArea.CalculateArea()
    {
        var result = 0d;
        if (Math.Pow(_sides[0], 2) + Math.Pow(_sides[1], 2) == Math.Pow(_sides[2], 2))
        {
            result = (_sides[0] * _sides[1]) / 2;
        }
        else
        {
            var semiPerimeter = _sides.Sum() / 2;
            result = Math.Sqrt(semiPerimeter * (semiPerimeter - _sides[0]) * (semiPerimeter - _sides[1]) * (semiPerimeter - _sides[2]));
        }

        return result;
    }
}
