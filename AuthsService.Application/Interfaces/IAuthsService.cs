using AuthsService.Application.Models.Params;
using AuthsService.Contracts.Models.Response;

namespace AuthsService.Application.Interfaces;

public interface IAuthsService
{
    public Task<AuthResponse> GetJwtTokenAsync(AuthParams param, CancellationToken ct);
}