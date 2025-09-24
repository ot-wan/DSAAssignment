using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAssignment
{
    public class Subject
    {
        // Constants
        public const string DEFAULT_SUBJECT_CODE = "NO CODE";
        public const string DEFAULT_SUBJECT_NAME = "NO NAME";
        public const decimal DEFAULT_SUBJECT_COST = 0.0m;

        // Getters and Setters
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public decimal SubjectCost { get; set; }

        // Constructors
        // All-arg Constructor
        public Subject(string subjectCode, string subjectName, decimal subjectCost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            SubjectCost = subjectCost;
        }

        // No-arg Constructor
        public Subject() : this(DEFAULT_SUBJECT_CODE, DEFAULT_SUBJECT_NAME, DEFAULT_SUBJECT_COST)
        {

        }

        // ToString
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{ Subject Code: ");
            sb.Append(SubjectCode);
            sb.Append(" Subject Name: ");
            sb.Append(SubjectName);
            sb.Append(" Subject Cost: ");
            sb.Append(SubjectCost);
            sb.Append(" }");
            return sb.ToString();
        }
    }
}
