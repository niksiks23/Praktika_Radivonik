using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PractCS.DAL.Context
{
    public class EquipmentContext : DbContext
    {
        public EquipmentContext() : base("name=EquipmentConnection") { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentAssignment> EquipmentAssignments { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipment>()
                .HasIndex(e => e.InventoryNumber)
                .IsUnique();

            modelBuilder.Entity<InstalledSoftware>()
                .HasRequired(i => i.Equipment)
                .WithMany(e => e.InstalledSoftwares)
                .HasForeignKey(i => i.EquipmentId);

            modelBuilder.Entity<InstalledSoftware>()
                .HasRequired(i => i.License)
                .WithMany(l => l.InstalledSoftwares)
                .HasForeignKey(i => i.LicenseId);

            base.OnModelCreating(modelBuilder);
        }
    }

}
