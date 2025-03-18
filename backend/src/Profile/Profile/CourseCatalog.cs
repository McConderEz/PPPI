namespace Profile;

/// <summary>
/// Класс для управления каталогом курсов.
/// </summary>
public class CourseCatalog
{
    /// <summary>
    /// Добавление нового курса.
    /// </summary>
    /// <param name="courseName">Название курса.</param>
    public void AddCourse(string courseName)
    {
        Console.WriteLine($"Курс добавлен: {courseName}");
    }

    /// <summary>
    /// Просмотр списка курсов.
    /// </summary>
    public void ViewCourses()
    {
        Console.WriteLine("Просмотр списка курсов.");
    }
}