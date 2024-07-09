using Application.Extension.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using System;
using System.Security.Claims;

namespace WebUI.Components.Layout.Identity;

internal static class SignOutEndpoint
{
    public static IEndpointConventionBuilder MapSignOutEndpoint(this IEndpointRouteBuilder endpoint)
    {
        ArgumentNullException.ThrowIfNull(endpoint, nameof(endpoint));
        var accountGroup = endpoint.MapGroup("/Account");
        accountGroup.MapPost("/Logout",
            async (ClaimsPrincipal user, SignInManager<ApplicationUser> signInNanager) =>
            {
                await signInNanager.SignOutAsync();
                return TypedResults.LocalRedirect("/Account/Login");
            });
        return accountGroup;
    }
}
