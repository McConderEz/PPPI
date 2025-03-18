namespace Educational;

/// <summary>
/// Класс для управления календарем курсов.
/// </summary>
public class CoursesCalendar
{
    /// <summary>
    /// Добавление события в календарь.
    /// </summary>
    /// <param name="eventName">Название события.</param>
    /// <param name="eventDate">Дата события.</param>
    public void AddEvent(string eventName, DateTime eventDate)
    {
        Console.WriteLine($"Событие добавлено в календарь: {eventName} на {eventDate}");
    }

    /// <summary>
    /// Просмотр событий в календаре.
    /// </summary>
    public void ViewEvents()
    {
        Console.WriteLine("Просмотр событий в календаре.");
    }
}