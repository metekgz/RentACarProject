using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Models.Concrete
{
    public class Brand:IModel
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
