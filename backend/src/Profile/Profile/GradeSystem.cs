namespace Profile;

/// <summary>
/// Класс для управления системой оценок.
/// </summary>
public class GradeSystem
{
    /// <summary>
    /// Оценка курса.
    /// </summary>
    /// <param name="courseId">Идентификатор курса.</param>
    /// <param name="grade">Оценка.</param>
    public void GradeCourse(int courseId, int grade)
    {
        Console.WriteLine($"Курс {courseId} оценен на {grade} баллов.");
    }

    /// <summary>
    /// Просмотр оценок.
    /// </summary>
    public void ViewGrades()
    {
        Console.WriteLine("Просмотр оценок.");
    }
}