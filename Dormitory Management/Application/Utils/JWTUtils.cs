using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Utils
{
    public static class JWTUtils
    {
        public static bool IsExpiredToken(this string token, DateTime now)
        {
            JwtSecurityToken jwt = new JwtSecurityToken(token);
            if (jwt.ValidTo < now) return true;
            return false;
        }

    }
}
