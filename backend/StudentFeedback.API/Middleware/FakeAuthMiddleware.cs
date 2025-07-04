using System.Security.Claims;

public class FakeAuthMiddleware
{
    private readonly RequestDelegate _next;

    public FakeAuthMiddleware(RequestDelegate next) => _next = next;

    public async Task InvokeAsync(HttpContext context)
    {
        // Simulate user role via headers or query param
        var role = context.Request.Headers["x-user-role"].FirstOrDefault();
        if (!string.IsNullOrEmpty(role))
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, "testuser"),
                new Claim(ClaimTypes.Role, role)
            };

            var identity = new ClaimsIdentity(claims, "FakeAuth");
            context.User = new ClaimsPrincipal(identity);
        }

        await _next(context);
    }
}