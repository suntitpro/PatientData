using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using PatientData.DataContext;
using PatientData.Models;

namespace PatientData.Controllers
{
    [EnableCors("*", "*", "GET")]
    [Authorize]
    public class PatientsController : ApiController
    {
        public IEnumerable<Patient> Get()
        {
            using (var db = new ApplicationDb())
            {
                return db.Patients.Include("Ailments").Include("Medications").ToList();
            }
        }

        public IHttpActionResult Get(int id)
        {
            using (var db = new ApplicationDb())
            {
                var patient = db.Patients.Include("Ailments").Include("Medications").First(i => i.Id == id);
                if (patient == null)
                {
                    return NotFound();
                }
                return Ok(patient);
            }
        }

        [Route("api/patients/{id:int}/medications")]
        public IHttpActionResult GetMedications(int id)
        {
            using (var db = new ApplicationDb())
            {
                var patient = db.Patients.Include("Ailments").Include("Medications").First(i => i.Id == id);
                if (patient == null)
                {
                    return NotFound();
                }
                return Ok(patient.Medications);
            }
        }
    }
}
