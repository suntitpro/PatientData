using System.Collections.Generic;
using System.Linq;

namespace PatientData.Models
{
    public static class DbConfig
    {
        public static void Seed()
        {
            using (var db = new ApplicationDbContext())
            {
                if (db.Patients.AsQueryable().Any(p => p.Name == "Scott")) return;
                var data = new List<Patient>
                {
                    new Patient
                    {
                        Name = "Scott",
                        Ailments = new List<Ailment> {new Ailment() {Name = "Crazy"}},
                        Medications = new List<Medication> {new Medication {Name = "Some medication1", Doses = 5}}
                    },
                    new Patient
                    {
                        Name = "Joy",
                        Ailments = new List<Ailment> {new Ailment() {Name = "Crazy"}},
                        Medications = new List<Medication> {new Medication {Name = "Some medication2", Doses = 4}}
                    },
                    new Patient
                    {
                        Name = "Sarah",
                        Ailments = new List<Ailment> {new Ailment() {Name = "Crazy"}},
                        Medications = new List<Medication> {new Medication {Name = "Some medication1", Doses = 7}}
                    }
                };

                db.Patients.AddRange(data);
                db.SaveChanges();
            }
        }
    }
}