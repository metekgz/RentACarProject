using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Models.Concrete
{
   public class Rental:IModel
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime? RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
