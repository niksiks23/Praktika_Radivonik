using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Maintenance
    {
        public int Id { get; set; }
        public int EquipmentId { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string MaintenanceType { get; set; } 
        public string Description { get; set; }
        public decimal? Cost { get; set; }
        public string PerformedBy { get; set; }
        public DateTime? NextMaintenanceDate { get; set; }

        public virtual Equipment Equipment { get; set; }
    }
}
