using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            AppointmentService ap1 = new AppointmentService(new Patient("John Smith", "986782342", "5555-555-555", "43"), DateTime.Now, "Wall Street", new Doctor("Armand", "Surgeon"));
            Console.WriteLine($"Appointment ID: {ap1.Identifier}");
        }
    }
}
