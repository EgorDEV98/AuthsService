namespace AuthsService.Application.Models.Params;

/// <summary>
/// Параметры аунтефикации
/// </summary>
public class AuthParams
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public required Guid UserId { get; set; }
    
    /// <summary>
    /// Имя пользователя
    /// </summary>
    public required string Name { get; set; }
}