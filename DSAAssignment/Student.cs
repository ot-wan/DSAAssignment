using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAssignment
{
    public class Student: Person, IComparable, IComparable<Student>
    {
        // Default Constants
        public const string DEFAULT_STUDENTID = "000000000";
        public const string DEFAULT_PROGRAM = "NO PROGRAM";
        
        // Getters and Setters
        public string StudentID { get; private set; }
        public string Program { get; set; }
        public DateTime DateRegistered { get; private set; }
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

        /// <summary>
        /// Checks if two students are the same student and returns the result
        /// </summary>
        /// <param name="obj">The object to compare with</param>
        /// <returns>True if the Student objects are the same, otherwise False</returns>
        public override bool Equals(object obj)
        {
            if ( obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Student student = (Student) obj;
            return student.StudentID == this.StudentID;
        }

         /// <summary>
         /// Compares two Student objects, and returns true if they are equal
         /// </summary>
         /// <param name="student1">The first Student object to compare</param>
         /// <param name="student2">The second Student object to compare</param>
         /// <returns>True if the Student objects are equal, otherwise False</returns>
        public static bool operator == (Student student1, Student student2)
        {
            return object.Equals(student1, student2);
        }

        /// <summary>
        /// Compares two Student objects, and returns true if they are not equal
        /// </summary>
        /// <param name="student1">The first Student object to compare</param>
        /// <param name="student2">The second Student object to compare</param>
        /// <returns>True if the Student objects are not equal, otherwise False</returns>
        public static bool operator != (Student student1, Student student2)
        {
            return !object.Equals(student1, student2);
        }

        /// <summary>
        /// Generates and returns the hash code for the Student object
        /// </summary>
        /// <returns>The hash code of the Student object</returns>
        public override int GetHashCode()
        {
            return this.StudentID.GetHashCode();
        }

        /// <summary>
        /// Compares a Student object to another object
        /// </summary>
        /// <param name="other">The object to compare to</param>
        /// <returns>1, 0, or -1 depending on the result of the comparison of the StudentID properties</returns>
        /// <exception cref="ArgumentNullException">Thrown when the provided object is null</exception>
        /// <exception cref="ArgumentException">Thrown when the provited object is not a Student object</exception>
        public int CompareTo(object other)
        {
            if (other == null)
                throw new ArgumentNullException("other");
            if (!(other is Student))
                throw new ArgumentException("Expected Student instance", "other");
            return CompareTo((Student)other);
        }

        /// <summary>
        /// Compares one Student object instance with another
        /// </summary>
        /// <param name="other">The Student object to comare to</param>
        /// <returns>1, 0, or -1 depending on the result of the comparison of the StudentID properties</returns>
        public int CompareTo(Student other)
        {
            return this.StudentID.CompareTo(other.StudentID);
        }
    }
}
