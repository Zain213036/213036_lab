using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace labfinal.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }