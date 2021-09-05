using System;

namespace Library
{
    public class Doctor
    {

        public string Name { get ; }
        public string Specialization { get ; }

        public Doctor(String name, String specialization)
        {
            this.Name = name;
            this.Specialization = specialization;
        }
    }
}
