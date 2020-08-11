using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;

namespace JwtToken.Respository
{
    public class TokenManager
    {
        private static string Secret = "XCAP05H6LoKvbRRa/QkqLNMI7cOHguaRyHzyg7n5qEkGjQmtBhz4SzYh4Fqwjyi3KJHlSXKPwVu2+bXr6CtpgQ==";

        public static string GenerateToken(string username)
        {
            byte[] key = Convert.FromBase64String(Secret);
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(key);
            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            ClaimsIdentity claims = new ClaimsIdentity(new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, username)
                }
            );
            SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = claims,
                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = signingCredentials
            };
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            var plainToken = handler.CreateToken(securityTokenDescriptor);
            var signedandEncodedToken = handler.WriteToken(plainToken);
            return signedandEncodedToken;
        }

        public static string ValidateToken(string token)
        {
           ClaimsPrincipal principal = GetPrincipal(token);
           ClaimsIdentity claims =(ClaimsIdentity) principal.Identity;
           Claim usernameClaim=claims.FindFirst(ClaimTypes.Name);
            string Username = usernameClaim.Value;
            return Username;
        }


        public static ClaimsPrincipal GetPrincipal(string token)
        {
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            JwtSecurityToken jwtToken = (JwtSecurityToken)handler.ReadToken(token);
            byte[] key=Convert.FromBase64String(Secret);
            TokenValidationParameters parameters = new TokenValidationParameters()
            {
                RequireExpirationTime = true,
                ValidateIssuer = false,
                ValidateAudience = false,
                IssuerSigningKey = new SymmetricSecurityKey(key)

            };
            ClaimsPrincipal principal= handler.ValidateToken(token, parameters, out SecurityToken securityToken);
            return principal;
        }
    }
}