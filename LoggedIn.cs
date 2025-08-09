using System.Security.Claims;

namespace WMS;

public record LoggedIn (string Username,string Password)
{
    public Claim[] ToClaims() =>
        [
        new Claim(ClaimTypes.Name, Username ),
         new Claim("Password", Password )
    ];
}
