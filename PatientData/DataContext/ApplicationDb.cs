using System.Data.Entity;
using PatientData.Models;

namespace PatientData.DataContext
{
    public class ApplicationDb : DbContext
    {
        public ApplicationDb() : base("DefaultConnection")
        {
            
        }
        public DbSet<Patient> Patients { get; set; }
    }
}