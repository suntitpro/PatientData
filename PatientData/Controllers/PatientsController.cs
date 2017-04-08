using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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

        public IHttpActionResult Get(int id)
        {
            using (var db = new ApplicationDbContext())
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
            using (var db = new ApplicationDbContext())
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
