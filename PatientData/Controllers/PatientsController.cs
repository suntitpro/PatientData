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

        public HttpResponseMessage Get(int id)
        {
            using (var db = new ApplicationDbContext())
            {
                var patient = db.Patients.Include("Ailments").Include("Medications").First(i => i.Id == id);
                return patient == null ? Request.CreateErrorResponse(HttpStatusCode.NotFound, "Patient not found") : Request.CreateResponse(patient);
            }
        }
    }
}
