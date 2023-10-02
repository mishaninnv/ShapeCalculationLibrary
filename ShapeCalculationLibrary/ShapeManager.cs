using ShapeCalculationLibrary.Interfaces;

namespace ShapeCalculationLibrary;

/// <summary>
/// Менеджер для работы с фигурами.
/// </summary>
public class ShapeManager
{
    /// <summary>
    /// Получить площадь фигуры.
    /// </summary>
    /// <param name="shape">Фигура.</param>
    /// <returns>Площадь переданной фигуры с округлением до 2 значений после запятой.</returns>
    public static double GetAreaShape(IArea shape)
    {
        return Math.Round(shape.CalculateArea(), 2);
    }
}
