using System.Collections.Generic;

namespace PatientData.Models
{
    public class Patient
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public ICollection<Ailment> Ailments { get; set; }
        public ICollection<Medication> Medications { get; set; }
    }

    public class Medication
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Doses { get; set; }
        
    }

    public class Ailment
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}