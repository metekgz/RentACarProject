using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        // base demek yani result anlamına geliyor
        public SuccessResult(string message) : base(true, message)
        {

        }
        // true default verildi
        public SuccessResult() : base(true)
        {

        }
    }
}
