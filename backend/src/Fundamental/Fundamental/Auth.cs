namespace Fundamental;

using System;

public class Auth
{
    /// <summary>
    /// Метод для регистрации нового пользователя.
    /// </summary>
    /// <param name="username">Имя пользователя.</param>
    /// <param name="password">Пароль пользователя.</param>
    public void RegisterUser(string username, string password)
    {
        Console.WriteLine($"Пользователь {username} успешно зарегистрирован.");
    }

    /// <summary>
    /// Метод для входа пользователя в систему.
    /// </summary>
    /// <param name="username">Имя пользователя.</param>
    /// <param name="password">Пароль пользователя.</param>
    public void LoginUser(string username, string password)
    {
        Console.WriteLine($"Пользователь {username} вошел в систему.");
    }

    /// <summary>
    /// Метод для выполнения двухфакторной аутентификации.
    /// </summary>
    /// <param name="token">Токен для аутентификации.</param>
    public void TwoFactorAuthentication(string token)
    {
        Console.WriteLine($"Двухфакторная аутентификация успешна. Токен: {token}");
    }
}