using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class EquipmentAssignment
    {
        public int Id { get; set; }
        public int EquipmentId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime AssignmentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Purpose { get; set; }
        public string Notes { get; set; }

        public virtual Equipment Equipment { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
