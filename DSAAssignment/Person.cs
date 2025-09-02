using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAssignment
{
    internal class Person
    {
        //// Variables
        //public string name;
        //private string email;
        //private string phoneNumber;
        //private Address address;

        // Default constants
        public const string DEFAULT_NAME = "NO NAME";
        public const string DEFAULT_EMAIL = "";
        public const string DEFAULT_PHONE_NUMBER = "";

        // Getters and Setters
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }

        // Constructors
        // All-arg Constructor
        public Person(string name, string email, string phoneNumber, Address address)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        // No-arg constructor
        public Person() : this(DEFAULT_NAME, DEFAULT_EMAIL, DEFAULT_PHONE_NUMBER, new Address())
        {

        }

        // ToString
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{ Name: ");
            sb.Append(Name);
            sb.Append(" Email: ");
            sb.Append(Email);
            sb.Append(" Phone Number: ");
            sb.Append(PhoneNumber);
            sb.Append(" Address: ");
            sb.Append(Address);
            sb.Append(" }");
            return sb.ToString();
        }
    }
}
