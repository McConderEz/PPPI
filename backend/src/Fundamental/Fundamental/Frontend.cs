namespace Fundamental;

/// <summary>
/// Класс для управления фронтендом платформы.
/// </summary>
public class Frontend
{
    /// <summary>
    /// Отображение главной страницы.
    /// </summary>
    public void DisplayHomePage()
    {
        Console.WriteLine("Отображение главной страницы.");
    }

    /// <summary>
    /// Отображение страницы курса.
    /// </summary>
    /// <param name="courseId">Идентификатор курса.</param>
    public void DisplayCoursePage(int courseId)
    {
        Console.WriteLine($"Отображение страницы курса {courseId}.");
    }
}