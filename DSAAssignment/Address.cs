using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAssignment
{
    internal class Address
    {
        //// Variables
        //private int streetNum;
        //private string streetName;
        //private string suburb;
        //private string postcode;
        //private string state;

        // Constants
        public const int DEFAULT_STREET_NUM = -1;
        public const string DEFAULT_STREET_NAME = "NOT PROVIDED";
        public const string DEFAULT_SUBURB = null;
        public const string DEFAULT_POSTCODE = "0000";
        public const string DEFAULT_STATE = null;

        // Getters and setters
        public int StreetNum { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }

        // Constructors
        // All-arg constructor
        public Address(int streetNum, string streetName, string suburb, string postcode, string state)
        {
            StreetNum = streetNum;
            StreetName = streetName;
            Suburb = suburb;
            Postcode = postcode;
            State = state;
        }

        // No-arg constructor
        public Address() : this(DEFAULT_STREET_NUM, DEFAULT_STREET_NAME, DEFAULT_SUBURB, DEFAULT_POSTCODE, DEFAULT_STATE)
        {

        }

        // ToString
        public override string ToString()
        {
            StringBuilder msg = new StringBuilder();
            msg.Append("{ Street number: ");
            msg.Append(StreetNum);
            msg.Append(" Street Name: ");
            msg.Append(StreetName);
            msg.Append(" Suburb: ");
            msg.Append(Suburb);
            msg.Append(" Postcode: ");
            msg.Append(Postcode);
            msg.Append(" State: ");
            msg.Append(State);
            msg.Append(" }");
            return msg.ToString();
        }
    }
}
