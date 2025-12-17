using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set; }
    }
}
