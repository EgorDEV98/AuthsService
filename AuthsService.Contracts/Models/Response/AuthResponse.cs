namespace AuthsService.Contracts.Models.Response;

/// <summary>
/// Модель ответа авторизации
/// </summary>
public class AuthResponse
{
    /// <summary>
    /// JWT токен
    /// </summary>
    public string AccessToken { get; set; }
}