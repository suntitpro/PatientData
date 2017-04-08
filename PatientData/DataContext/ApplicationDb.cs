using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using PatientData.Models;

namespace PatientData.DataContext
{
    public class ApplicationDb : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDb()
            : base("DefaultConnection")
        {
        }

        public DbSet<Patient> Patients { get; set; }

        public static ApplicationDb Create()
        {
            return new ApplicationDb();
        }
    }
}