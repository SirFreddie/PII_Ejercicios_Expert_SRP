using System;
using System.Text;

namespace Library
{
    public class Validator
    {   
        // Validar Doctor.
        public static bool IsDoctorValid(Doctor doctor)
        {
            bool isValid = true;

            if(!IsNameValid(doctor.Name))
            {
                Console.WriteLine("Unable to schedule appointment, Doctor Name is required");
                isValid = false;
            }

            if(!IsSpecializationValid(doctor.Specialization))
            {
                Console.WriteLine("Unable to schedule appointment, Doctor Specialization is required");
                isValid = false;
            }

            if (isValid)
            {
                return true;
            }
            return false;
        }

        // Validar Patient.
        public static bool IsPatientValid(Patient patient)
        {
            bool isValid = true;

            if(!IsNameValid(patient.Name))
            {
                Console.WriteLine("Unable to schedule appointment, Patient Name is required");
                isValid = false;
            }

            if(!IsIdValid(patient.Id))
            {
                Console.WriteLine("Unable to schedule appointment, Patient ID is required");
                isValid = false;
            }

            if(!IsNameValid(patient.PhoneNumber))
            {
                Console.WriteLine("Unable to schedule appointment, Patient Phone Number is required");
                isValid = false;
            }

            if(!IsAgeValid(patient.Age))
            {
                Console.WriteLine("Unable to schedule appointment, Patient Age is required");
                isValid = false;
            }

            if (isValid)
            {
                return true;
            }
            return false;
        }

        public static bool IsNameValid(String name)
        {
            return !(string.IsNullOrEmpty(name));
        } 

        public static bool IsIdValid(String id)
        {
            return !(string.IsNullOrEmpty(id));
        } 
                
        public static bool IsPhoneNumberValid(String phoneNumber)
        {
            return !(string.IsNullOrEmpty(phoneNumber));
        } 

        public static bool IsAppointmentPlaceValid(String appoinmentPlace)
        {
            return !(string.IsNullOrEmpty(appoinmentPlace));
        } 

        public static bool IsAgeValid(String age)
        {
            return !(string.IsNullOrEmpty(age));
        } 

        public static bool IsSpecializationValid(String specialization)
        {
            return !(string.IsNullOrEmpty(specialization));
        } 

    
    }
}
