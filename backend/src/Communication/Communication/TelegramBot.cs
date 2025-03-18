namespace Communication;

/// <summary>
/// Класс для взаимодействия с Telegram-ботом.
/// </summary>
public class TelegramBot
{
    /// <summary>
    /// Отправка сообщения через Telegram-бота.
    /// </summary>
    /// <param name="chatId">Идентификатор чата.</param>
    /// <param name="message">Сообщение для отправки.</param>
    public void SendMessage(long chatId, string message)
    {
        Console.WriteLine($"Сообщение отправлено в Telegram чат {chatId}: {message}");
    }
}