using System;
using System.Text;
using System.Collections;

namespace Library
{
    public class AppointmentService
    {   
        private static int identifier = 0;

        public string Identifier { get ; }

        private ArrayList appointmentIdList = new ArrayList();

        public AppointmentService(Patient patient, DateTime date, string appoinmentPlace, Doctor doctor)
        {
            Boolean isValid = true;

            Console.WriteLine("Scheduling appointment...");

            if (Validator.IsDoctorValid(doctor) && Validator.IsPatientValid(patient) && Validator.IsAppointmentPlaceValid(appoinmentPlace))
            {
                Console.WriteLine("Appoinment Scheduled");
                identifier = identifier + 1; // Incrementa en +1 el identificador. 
                this.Identifier = identifier.ToString();
            }
        }
    }
}
