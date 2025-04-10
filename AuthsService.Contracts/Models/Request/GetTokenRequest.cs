namespace AuthsService.Contracts.Models.Request;

/// <summary>
/// Получить JWT токен
/// </summary>
public class GetTokenRequest
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