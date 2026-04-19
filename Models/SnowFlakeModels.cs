namespace SnowfallGameFNA.Models;

/// <summary>
/// Представляет одну снежинку на экране с её позицией, размером и скоростью падения.
/// </summary>
internal struct SnowFlakeModels
{
    /// <summary>
    /// горизонтальная координата снежинки на экране
    /// </summary>
    public float X { get; set; }

    /// <summary>
    /// вертикальная координата снежинки на экране
    /// </summary>
    public float Y { get; set; }

    /// <summary>
    /// размер снежинки в пикселях
    /// </summary>
    public int Size { get; set; }

    /// <summary>
    /// скорость падения снежинки
    /// </summary>
    public float Speed { get; set; }

    /// <summary>
    /// Инициализирует новый экземпляр структуры SnowFlakeModels с указанными позицией, размером и скоростью
    /// </summary>
    public SnowFlakeModels(float x, float y, int size, float speed)
    {
        X = x;
        Y = y;
        Size = size;
        Speed = speed;
    }
}
