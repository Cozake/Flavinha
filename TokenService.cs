using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Academia.Api.Models;

namespace Academia.Api.Services
{
    public class TokenService
    {
        private readonly IConfiguration _config;

        public TokenService(IConfiguration config)
        {
            _config = config;
        }

        public string GenerateToken(Aluno aluno)
        {
            var key = Encoding.UTF8.GetBytes(_config["Jwt:Key"]!);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, aluno.Id.ToString()),
                new Claim(ClaimTypes.Email, aluno.Email),
                new Claim(ClaimTypes.Name, aluno.Nome)
            };

            var credentials = new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256
            );

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.UtcNow.AddHours(8),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
