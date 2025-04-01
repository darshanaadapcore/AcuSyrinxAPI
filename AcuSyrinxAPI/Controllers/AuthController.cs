using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Web.Http;
using Microsoft.IdentityModel.Tokens;

namespace AcuSyrinxAPI.Controllers
{
    [RoutePrefix("api")]
    public class AuthController : ApiController
    {
        [AllowAnonymous]
        [HttpPost]
        [Route("authenticate")]
        public IHttpActionResult Authenticate([FromBody] LoginRequest login)
        {
            if (login == null || login.Username != "admin" || login.Password != "password")
                return Unauthorized();

            var key = Encoding.UTF8.GetBytes(Startup.GetSecurityKey());
            var credentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, login.Username),
                new Claim(ClaimTypes.Role, "Admin"),
                new Claim("CustomClaim", "CustomValue")
            };

            var jwtToken = new JwtSecurityToken(
                issuer: Startup.GetIssuer(),
                audience: Startup.GetAudience(),
                expires: DateTime.UtcNow.AddMinutes(60),
                claims: claims,
                signingCredentials: credentials
            );

            string token = new JwtSecurityTokenHandler().WriteToken(jwtToken);

            return Ok(new { token });
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
