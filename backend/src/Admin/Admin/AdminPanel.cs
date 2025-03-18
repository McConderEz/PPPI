namespace Admin;

/// <summary>
/// Класс для управления административной панелью.
/// </summary>
public class AdminPanel
{
    /// <summary>
    /// Управление пользователями: просмотр, добавление, удаление.
    /// </summary>
    public void ManageUsers()
    {
        Console.WriteLine("Управление пользователями: просмотр, добавление, удаление.");
    }

    /// <summary>
    /// Управление курсами: создание, редактирование, удаление.
    /// </summary>
    public void ManageCourses()
    {
        Console.WriteLine("Управление курсами: создание, редактирование, удаление.");
    }

    /// <summary>
    /// Просмотр статистики: количество пользователей, курсов, активность.
    /// </summary>
    public void ViewStatistics()
    {
        Console.WriteLine("Просмотр статистики: количество пользователей, курсов, активность.");
    }
}