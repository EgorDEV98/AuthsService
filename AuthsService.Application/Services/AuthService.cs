using AuthsService.Application.Interfaces;
using AuthsService.Application.Models.Params;
using AuthsService.Contracts.Models.Response;
using CommonLib.Other.JwtProvider;

namespace AuthsService.Application.Services;

public class AuthService : IAuthsService
{
    private readonly IJwtProvider _jwtProvider;

    public AuthService(IJwtProvider jwtProvider)
    {
        _jwtProvider = jwtProvider;
    }
    
    /// <summary>
    /// Получить токен
    /// </summary>
    /// <param name="param"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AuthResponse> GetJwtTokenAsync(AuthParams param, CancellationToken ct)
    {
        var jwtToken = _jwtProvider.GenerateJwtToken(new JwtModel()
        {
            UserId = param.UserId,
            Name = param.Name,
        });
        await Task.CompletedTask;
        
        return new AuthResponse()
        {
            AccessToken = jwtToken
        };
    }
}