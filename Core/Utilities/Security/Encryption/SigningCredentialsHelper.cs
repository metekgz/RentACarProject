using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Encryption
{
    // wep apilerinin kullanabileceği jwtlarının oluşturulması ve yönetilmesi
    public class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            // hashing işleminde anahtar olarak securityKey'i kullanacak 
            // şifreleme olarak ise güvenlik algoritmasından HmacSha512Signature'yi kullanacak
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
