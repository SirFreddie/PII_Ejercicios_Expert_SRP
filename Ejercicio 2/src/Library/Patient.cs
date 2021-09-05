using System;

namespace Library
{
    public class Patient
    {
        public string Name { get ; }
        public string Id { get ; }
        public string PhoneNumber { get ; }
        public string Age { get ; }

        public Patient(String name, String id, String phoneNumber, String age)
        {
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
            this.Age = age;
        }
    }
}
