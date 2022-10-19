using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Models.Concrete
{
   public class Color:IModel
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
