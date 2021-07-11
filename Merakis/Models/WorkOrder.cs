using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Merakis.Models
{
    public class WorkOrder
    {
        public int Id { get; set; }

        public string status { get; set; }

        public string evidence { get; set; }

        public string notes { get; set; }

        public DateTime dateFrom { get; set; }

        public DateTime dateTo { get; set; }

        public int VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }

        public int MechanicalId { get; set; }

        public Mechanical Mechanical { get; set; }

        public int ServiceId { get; set; }

        public Service Service { get; set; }
    }
}
