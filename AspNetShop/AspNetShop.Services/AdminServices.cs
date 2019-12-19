﻿using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using AspNetShop.Options;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AspNetShop.Services
{
    public class AdminServices
    {
        private readonly string jwtSecret;
        private readonly string password = "admin";

        public AdminServices(IOptions<SecretOptions> secretOptions)
        {
            this.jwtSecret = secretOptions.Value.JWTSecret;
        }

        public string Authenticate(string password)
        {
            if (password != this.password)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(jwtSecret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Role, "admin")
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(securityToken);
        }
    }
}
