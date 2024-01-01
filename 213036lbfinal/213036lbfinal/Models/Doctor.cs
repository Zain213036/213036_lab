using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _213036lbfinal.Models
{
    public class Doctor

    {
        public int DoctorId { get; set; }
    public string Name { get; set; }
    public string Specialization { get; set; }
    public string Contact { get; set; }
    public virtual ICollection<Appointment> Appointments { get; set; }
}
}