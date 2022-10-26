using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models.Concrete;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        // token üretecek yer
        // kullanıcı bilgilerini(adı,şifre vb) girdiğinde doğru ise çalışacak jwt üretecek ve onu verecek
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
