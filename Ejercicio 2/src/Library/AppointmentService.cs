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

            if (Validator.IsDoctorValid(doctor) && Validator.IsPatientValid(patient))
            {
                isValid = true;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                Console.WriteLine("Unable to schedule appointment, Appoinment place is required");
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("Appoinment Scheduled");
                identifier = identifier + 1;
                this.Identifier = identifier.ToString();
            }
        }

    }
}
