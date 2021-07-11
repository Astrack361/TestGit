using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Merakis.Models
{
    public class Mechanical
    {
        public int Id { get; set; }

        public string IdCard { get; set; }

        public string name { get; set; }

        public string lastName { get; set; }

        public string secondLastName { get; set; }

        public string phoneNumber { get; set; }

        public string email { get; set; }

        public string criminalRecord { get; set; }

        public int WorkShopId { get; set; }

        public WorkShop WorkShop { get; set; }
    }
}
