using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public string InventoryNumber { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal PurchasePrice { get; set; }
        public string Status { get; set; } 
        public string Specifications { get; set; }

        public int EquipmentTypeId { get; set; }
        public virtual EquipmentType EquipmentType { get; set; }

        public int? DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public virtual ICollection<EquipmentAssignment> EquipmentAssignments { get; set; }
        public virtual ICollection<Maintenance> Maintenances { get; set; }
    }
}
