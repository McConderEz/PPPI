namespace Communication;

/// <summary>
/// Класс для отправки уведомлений пользователям.
/// </summary>
public class Notifications
{
    /// <summary>
    /// Отправка уведомления пользователю.
    /// </summary>
    /// <param name="userId">Идентификатор пользователя.</param>
    /// <param name="message">Сообщение для отправки.</param>
    public void SendNotification(int userId, string message)
    {
        Console.WriteLine($"Уведомление отправлено пользователю {userId}: {message}");
    }
}