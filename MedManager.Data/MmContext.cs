using MedManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedManager.Data
{
    public sealed class MmContext : DbContext
    {
        public MmContext(DbContextOptions<MmContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<DiagnosesToPatients> DiagnosesToPatients { get; set; }
        public DbSet<EmployeesToInspections> EmployeesToInspections { get; set; }
        public DbSet<EmployeesToPositions> EmployeesToPositions { get; set; }
        public DbSet<EmployeesToWards> EmployeesToWards { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<InspectionsToPatients> InspectionsToPatients { get; set; }
        public DbSet<InspectionType> InspectionTypes { get; set; }
        public DbSet<Medicament> Medications { get; set; }
        public DbSet<MedicamentsToPatients> MedicationsToPatients { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Plot> Plots { get; set; }
        public DbSet<Ward> Wards { get; set; }
    }
}
