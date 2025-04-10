using AuthsService.Application.Interfaces;
using AuthsService.Application.Models.Params;
using AuthsService.Contracts.Clients;
using AuthsService.Contracts.Models.Request;
using AuthsService.Contracts.Models.Response;
using CommonLib.Response;
using Microsoft.AspNetCore.Mvc;

namespace AuthsService.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthsController : ControllerBase, IAuthClient
{
    private readonly IAuthsService _authsService;

    public AuthsController(IAuthsService authsService)
    {
        _authsService = authsService;
    }
    
    /// <summary>
    /// Авторизоваться
    /// </summary>
    /// <param name="request"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    [HttpPost("auth")]
    public async Task<BaseResponse<AuthResponse>> GetTokenAsync(GetTokenRequest request, CancellationToken ct)
    {
        var result = await _authsService.GetJwtTokenAsync(new AuthParams()
        {
            Name = request.Name,
            UserId = request.UserId,
        }, ct);
        return AppResponse.Create(result);
    }
}