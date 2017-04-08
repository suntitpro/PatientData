using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using PatientData.Models;

namespace PatientData.Controllers
{
    public class PatientsController : ApiController
    {
        public IEnumerable<Patient> Get()
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Patients.Include("Ailments").Include("Medications").ToList();
            }
        }
    }
}
