using F1API.DTOs;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace F1API.Services
{
    public class AuthorizerService : IAuthorizerService
    {
        private readonly IConfiguration _configuration;

        public AuthorizerService(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public string GenerateToken(UserDTO user)
        {
            //Hardcoded: right now, I'm simulating a login attempt, this API does not have
            //a database, so the username and password will be false and magical values.
            if (user.Username != null && user.Password != null)
            {
                if (user.Username == "sid.watkins" && user.Password == "5&nn@")
                {
                    var secretkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"] ?? String.Empty));
                    var issuer = _configuration["JWT:Issuer"];
                    var audience = _configuration["JWT:Audience"];
                    var signinCredentials = new SigningCredentials(secretkey, SecurityAlgorithms.HmacSha256);
                    var tokenOptions = new JwtSecurityToken(
                        issuer: issuer,
                        audience: audience,
                        claims: new[] {
                            new Claim(type: ClaimTypes.Name, user.Username),
                            new Claim(type: ClaimTypes.Role, "authorized_guess")
                        },
                        expires: DateTime.UtcNow.AddDays(1),
                        signingCredentials: signinCredentials);

                    var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

                    return token;
                }
            }

            return String.Empty;

        }
    }
}
