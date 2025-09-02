using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAssignment
{
    internal class Enrolment
    {
        // Constants
        public const string DEFAULT_DATE_ENROLED = "NOT PROVIDED";
        public const string DEFAULT_GRADE = "NONE";
        public const string DEFAULT_SEMESTER = "";

        // Getters and Setters

        public string DateEnroled { get; set; }
        public string Grade { get; set; }
        public string Semester { get; set; }
        public Subject Subject { get; set; }

        // Constructors
        // All-arg Constructor
        public Enrolment(string dateEnroled, string grade, string semester, Subject subject)
        {
            DateEnroled = dateEnroled;
            Grade = grade;
            Semester = semester;
            Subject = subject;
        }

        // No-arg Constructor
        public Enrolment() : this(DEFAULT_DATE_ENROLED, DEFAULT_GRADE, DEFAULT_SEMESTER, new Subject())
        {

        }

        // ToString
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{ Date Enroled: ");
            sb.Append(DateEnroled);
            sb.Append(" Grade: ");
            sb.Append(Grade);
            sb.Append(" Semester: ");
            sb.Append(Semester);
            sb.Append(" Subject: ");
            sb.Append(Subject);
            sb.Append(" }");
            return sb.ToString();
        }
    }
}
