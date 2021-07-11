using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Merakis.Models
{
    public class Service
    {

        public int Id { get; set; }

        public string description { get; set; }

        public string category { get; set; }

        public decimal price { get; set; }
    }
}
