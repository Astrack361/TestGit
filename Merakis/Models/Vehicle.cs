using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Merakis.Models
{
    public class Vehicle
    {

        public int Id { get; set; }

        public string brand { get; set; }

        public string model { get; set; }

        public int year { get; set; }

        public string transmition { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

    }
}
