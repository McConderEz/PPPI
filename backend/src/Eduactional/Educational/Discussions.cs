namespace Educational;

/// <summary>
/// Класс для управления обсуждениями на форуме.
/// </summary>
public class Discussions
{
    /// <summary>
    /// Создание нового обсуждения.
    /// </summary>
    /// <param name="topic">Тема обсуждения.</param>
    public void CreateDiscussion(string topic)
    {
        Console.WriteLine($"Создано новое обсуждение: {topic}");
    }

    /// <summary>
    /// Добавление сообщения в обсуждение.
    /// </summary>
    /// <param name="discussionId">Идентификатор обсуждения.</param>
    /// <param name="message">Сообщение.</param>
    public void AddMessage(int discussionId, string message)
    {
        Console.WriteLine($"Сообщение добавлено в обсуждение {discussionId}: {message}");
    }
}