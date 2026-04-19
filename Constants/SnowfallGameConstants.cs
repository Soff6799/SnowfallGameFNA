namespace SnowfallGameFNA.Constants;

/// <summary>
/// Содержит все константы и настройки, используемые в игре "SnowfallGameFNA".
/// </summary>
public static class SnowfallGameConstants
{
    /// <summary>
    /// Ширина игрового окна в пикселях.
    /// </summary>
    public const int ScreenWidth = 1280;

    /// <summary>
    /// Высота игрового окна в пикселях.
    /// </summary>
    public const int ScreenHeight = 720;

    /// <summary>
    /// Общее количество одновременно отображаемых снежинок.
    /// </summary>
    public const int SnowflakeCount = 300;

    /// <summary>
    /// Минимальный размер снежинки в пикселях.
    /// </summary>
    public const int MinSize = 15;

    /// <summary>
    /// Максимальный размер снежинки в пикселях.
    /// </summary>
    public const int MaxSize = 40;

    /// <summary>
    /// Делитель для расчета скорости падения снежинки. Чем больше значение, тем медленнее падает снег.
    /// </summary>
    public const float SpeedDivisor = 20.0f;
}
