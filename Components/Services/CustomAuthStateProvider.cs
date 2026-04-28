using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace mgpSystem.Components.Services
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
           var user = new ClaimsPrincipal(new ClaimsIdentity()); //non-authenticated user

           return Task.FromResult(new AuthenticationState(user));
        }
    }
}