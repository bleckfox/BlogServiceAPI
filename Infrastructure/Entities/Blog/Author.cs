namespace Infrastructure.Entities.Blog;

/// <summary>
/// Модель автора поста
/// </summary>
public class Author : BaseEntity
{
    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; } = null!;
    
    /// <summary>
    /// Фамилия
    /// </summary>
    public string Surname { get; set; } = null!;
    
    /// <summary>
    /// Отчество
    /// </summary>
    public string? Patronymic { get; set; }
    
    /// <summary>
    /// Должность
    /// </summary>
    public string Appointment { get; set; } = null!;
    
    /// <summary>
    /// Почта
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// Пароль
    /// </summary>
    public string Password { get; set; } = null!;

    /// <summary>
    /// Признак активности
    /// </summary>
    public bool IsActive { get; set; }
    
    /// <summary>
    /// Признак администратора
    /// </summary>
    public bool IsAdmin { get; set; }
    
    /// <summary>
    /// Дата создания
    /// </summary>
    public DateTime CreatedDate { get; set; }
}