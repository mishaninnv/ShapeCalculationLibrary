namespace ShapeCalculationLibrary.Interfaces;

/// <summary>
/// Интерфейс для работы с площадью фигуры.
/// </summary>
public interface IArea
{
    /// <summary>
    /// Вычисление площади фигуры.
    /// </summary>
    /// <returns>Площадь фигуры.</returns>
    public double CalculateArea();
}