using _213036lbfinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _213036lbfinal.DAL
{
    public class  : System.Data.Entity.DropCreateDatabaseIfModelChanges<ClinicInitialzer>
    {
        protected override void Seed(ClinicContext context)
        {
            var patient = new List<Patient>
            {
            new Patient{FirstName="Carson",LastName="Alexander",Appointment=DateTime.Parse("2005-09-01")},
            new Patient{FirstName="Meredith",LastName="Alonso",Appointment=DateTime.Parse("2002-09-01")},
        
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Doctor{id=1050,FirstName="Carson",LastName="Alexander",},
            new Doctor{id=4022,FirstName="Meredith",LastName="Alonso",},
           
           
            };
            patients.ForEach(s => patients.Courses.Add(s));
            context.SaveChanges();
            var Appointment = new List<Appointment>
           
          
            
            };
    Appointment.ForEach(s => context.Appointments.Add(s));
            context.SaveChanges();
        }
    }
}
}