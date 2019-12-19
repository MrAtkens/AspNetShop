using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using AspNetShop.DataAccess;
using AspNetShop.Domain;
using AspNetShop.Options;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AspNetShop.Services
{
    public class UserService
    {
        private readonly AspNetShopContext context;
        private readonly string jwtSecret;

        public UserService(AspNetShopContext context, IOptions<SecretOptions> secretOptions)
        {
            this.context = context;
            this.jwtSecret = secretOptions.Value.JWTSecret;
        }

        public async Task<string> Authenticate(string phoneNumber, string code)
        {
            var user = await context.Users.FirstOrDefaultAsync(user => user.PhoneNumber == phoneNumber);

            if (user is null || String.IsNullOrEmpty(user.VerificationCode) || user.VerificationCode != code)
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(jwtSecret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, phoneNumber)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public async Task SaveCodeToUser(string phoneNumber, string code)
        {
            var user = await context.Users.FirstOrDefaultAsync(user => user.PhoneNumber == phoneNumber);

            if (user is null)
            {
                user = new User
                {
                    PhoneNumber = phoneNumber,
                    VerificationCode = code,
                    Cart = new Cart(),
                    FullName = "User-" + Guid.NewGuid().ToString(),
                    FavoriteProducts = new List<FavoriteProduct>()
                };
                
                await context.Users.AddAsync(user);

            }
            else
            {
                user.VerificationCode = code;
            }

            await context.SaveChangesAsync();
        }

        public async Task<bool> ConfirmUserCode(string phoneNumber, string code)
        {
            var user = await context.Users.FirstOrDefaultAsync(user => user.PhoneNumber == phoneNumber);

            if (user.VerificationCode == code)
            {
                user.IsConfirmed = true;
                return true;
            }

            user.IsConfirmed = false;
            return false;
        }
    }
}
