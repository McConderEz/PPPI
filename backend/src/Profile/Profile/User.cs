namespace Profile;

using System;

public class User
{
    private string _username;
    private string _bio;

    /// <summary>
    /// Метод для создания профиля пользователя.
    /// </summary>
    /// <param name="username">Имя пользователя.</param>
    /// <param name="bio">Информация о пользователе.</param>
    public void CreateProfile(string username, string bio)
    {
        _username = username;
        _bio = bio;
        Console.WriteLine($"Профиль пользователя {_username} создан. Описание: {_bio}");
    }

    /// <summary>
    /// Метод для редактирования профиля пользователя.
    /// </summary>
    /// <param name="newBio">Новая информация о пользователе.</param>
    public void EditProfile(string newBio)
    {
        _bio = newBio;
        Console.WriteLine($"Профиль пользователя {_username} обновлен. Новое описание: {_bio}");
    }
}