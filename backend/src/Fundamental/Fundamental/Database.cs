namespace Fundamental;

/// <summary>
/// Класс для управления базой данных.
/// </summary>
public class Database
{
    /// <summary>
    /// Выполнение SQL-запроса.
    /// </summary>
    /// <param name="query">SQL-запрос.</param>
    public void ExecuteQuery(string query)
    {
        Console.WriteLine($"Выполнен SQL-запрос: {query}");
    }

    /// <summary>
    /// Обновление данных в таблице.
    /// </summary>
    /// <param name="table">Название таблицы.</param>
    /// <param name="data">Данные для обновления.</param>
    public void UpdateData(string table, object data)
    {
        Console.WriteLine($"Данные в таблице {table} обновлены.");
    }
}