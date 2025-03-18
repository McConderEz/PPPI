namespace Mobile;

/// <summary>
/// Класс для управления мобильным приложением.
/// </summary>
public class MobileApp
{
    /// <summary>
    /// Отображение списка курсов.
    /// </summary>
    public void DisplayCourses()
    {
        Console.WriteLine("Отображение списка курсов в мобильном приложении.");
    }

    /// <summary>
    /// Выполнение задания.
    /// </summary>
    /// <param name="taskId">Идентификатор задания.</param>
    public void CompleteTask(int taskId)
    {
        Console.WriteLine($"Задание {taskId} выполнено.");
    }
}