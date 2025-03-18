namespace Educational;

/// <summary>
/// Класс для управления заданиями.
/// </summary>
public class TaskManagement
{
    /// <summary>
    /// Создание нового задания.
    /// </summary>
    /// <param name="taskName">Название задания.</param>
    public void CreateTask(string taskName)
    {
        Console.WriteLine($"Создано новое задание: {taskName}");
    }

    /// <summary>
    /// Оценка задания.
    /// </summary>
    /// <param name="taskId">Идентификатор задания.</param>
    /// <param name="grade">Оценка.</param>
    public void GradeTask(int taskId, int grade)
    {
        Console.WriteLine($"Задание {taskId} оценено на {grade} баллов.");
    }
}