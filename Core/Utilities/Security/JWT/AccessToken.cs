using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        // token jwt değeri kullanıcı api üzerinden girince token verilecek
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
