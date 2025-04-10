using AuthsService.Contracts.Models.Request;
using AuthsService.Contracts.Models.Response;
using CommonLib.Response;
using Refit;

namespace AuthsService.Contracts.Clients;

public interface IAuthClient
{
    /// <summary>
    /// Получить токен авторизации
    /// </summary>
    /// <param name="request"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    [Post("/Auths/Auth")]
    public Task<BaseResponse<AuthResponse>> GetTokenAsync(GetTokenRequest request, CancellationToken ct);
}