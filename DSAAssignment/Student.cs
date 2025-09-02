using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAssignment
{
    internal class Student: Person
    {
        //// Variables
        //private string studentID;
        //private string program;
        //private DateTime dateRegistered;

        // Default Constants
        public const string DEFAULT_STUDENTID = "000000000";
        public const string DEFAULT_PROGRAM = "NO PROGRAM";
        
        // Getters and Setters
        public string StudentID { get; set; }
        public string Program { get; set; }
        public DateTime DateRegistered { get; set; }
        public Enrolment Enrolment { get; set; }


        // Constructors
        // All-arg Constructor
        public Student(string studentID, string program, Enrolment enrolment, string name, string email, string phoneNumber, Address address) : base(name, email, phoneNumber, address)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = DateTime.Now;
            Enrolment = enrolment;
        }

        // No-arg Constructor
        public Student() : this(DEFAULT_STUDENTID, DEFAULT_PROGRAM, new Enrolment(), DEFAULT_NAME, DEFAULT_EMAIL, DEFAULT_PHONE_NUMBER, new Address(Address.DEFAULT_STREET_NUM, Address.DEFAULT_STREET_NAME, Address.DEFAULT_SUBURB, Address.DEFAULT_POSTCODE, Address.DEFAULT_STATE))
        {

        }

        // ToString
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{ Student ID: ");
            sb.Append(StudentID);
            sb.Append(" Program: ");
            sb.Append(Program);
            sb.Append(" Date Registered: ");
            sb.Append(DateRegistered);
            sb.Append(" Enrolment: ");
            sb.Append(Enrolment);
            sb.Append(base.ToString());
            sb.Append(" }");
            return sb.ToString();
        }
    }
}
