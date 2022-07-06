using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace API.Services
{
    public class TokenService : ITokenService
    {
        private readonly SymmetricSecurityKey _key;
        public TokenService(IConfiguration config)
        {
        //    _key = new SymmetricSecurityKey()
        }

        public string CreateToken(AppUser user)
        {
            throw new NotImplementedException();
        }
    }
}