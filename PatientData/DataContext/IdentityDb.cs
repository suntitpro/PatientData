using Microsoft.AspNet.Identity.EntityFramework;
using PatientData.Models;

namespace PatientData.DataContext
{
    public class IdentityDb : IdentityDbContext<ApplicationUser>
    {
        public IdentityDb()
            : base("DefaultConnection")
        {
        }

        public static IdentityDb Create()
        {
            return new IdentityDb();
        }
    }
}