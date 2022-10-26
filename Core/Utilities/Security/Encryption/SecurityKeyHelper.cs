using System;
using System.Collections.Generic;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    // şifreleme olan sistemlerde her şey byte[] formatında verilmesi gerekir
    // wep apideki appsettingsde oluşturulan SecurityKeyi aspnetin jwt token servicelerinin
    // anlayacağı hale getirilmesi gerekir

    public class SecurityKeyHelper
    {
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}
