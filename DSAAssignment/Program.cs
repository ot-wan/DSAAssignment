using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Testing Address
            Console.WriteLine("\nTesting Address...");
            Console.WriteLine("Testing Address All-Arg Constructor...");
            Address address1 = new Address(17, "Fake Street", "Adelaide", "5000", "SA");
            Console.WriteLine("Address 1: " + address1);
            Console.WriteLine("Testing Address No-Arg Constructor...");
            Address address2 = new Address();
            Console.WriteLine("Address 2: " + address2);

            //Testing Person
            Console.WriteLine("\nTesting Person...");
            Console.WriteLine("Testing Person All-Arg Constructor...");
            Person person1 = new Person("Jennifer Smith", "jsmith@email.com", "1234-567-890", address1);
            Console.WriteLine("Person 1: " + person1);
            Console.WriteLine("Testing Person No-Arg Constructor...");
            Person person2 = new Person("Jennifer Smith", "jsmith@email.com", "1234-567-890", address1);
            Console.WriteLine("Person 2: " + person2);

            // Testing Subject
            Console.WriteLine("\nTesting Subject...");
            Console.WriteLine("Testing Subject All-Arg Constructor...");
            Subject subject1 = new Subject("ICTPRG547", "Advanced Programming", 237.50m);
            Console.WriteLine("Subject 1: " + subject1);
            Console.WriteLine("Testing Subject No-Arg Constructor...");
            Subject subject2 = new Subject();
            Console.WriteLine("Subject 2: " + subject2);

            // Testing Enrolment
            Console.WriteLine("\nTesting Enrolment...");
            Console.WriteLine("Testing Enrolment All-Arg Constructor...");
            Enrolment enrolment1 = new Enrolment("2/6/2025", "NC", "S22025", subject1);
            Console.WriteLine("Enrolment 1: " + enrolment1);
            Console.WriteLine("Testing Enrolment No-Arg Constructor...");
            Enrolment enrolment2 = new Enrolment();
            Console.WriteLine("Enrolment 2: " + enrolment2);

            // Testing Student
            Console.WriteLine("\nTesting Student...");
            Console.WriteLine("Testing Enrolment All-Arg Constructor...");
            Student student1 = new Student("987654", "Diploma of IT", enrolment1, "Larry Kallen", "lkallen@email.com", "1234-567-891", address1);
            Console.WriteLine("Student 1" + student1);
            Console.WriteLine("Testing Student No-Arg Constructor...");
            Student student2 = new Student();
            Console.WriteLine("Student 2" + student2);

            // Testing Comparison and Hashing Methods
            Console.WriteLine("\nTesting Equals Method...");
            Console.WriteLine("Testing student1 Equals student2 (expecting false): " + student1.Equals(student2));
            Student student3 = student1;
            Console.WriteLine("Testing student1 Equals student3 (expecting true): " + student1.Equals(student3));
            Console.WriteLine("\nTesting Comparison Operators...");
            Console.WriteLine("Testing == operator...");
            Console.WriteLine("Testing student1 is equal to student2 (expecting false): " + (student1 == student2));
            Console.WriteLine("Testing != operator...");
            Console.WriteLine("Testing student1 is not equal to student2 (expecting true): " + (student1 != student2));
            Console.WriteLine("\nTesting Hash Code Generation...");
            Console.WriteLine("Hash code for student1: " + student1.GetHashCode());
            Console.WriteLine("Hash code for student2: " + student2.GetHashCode());

            // Close window after key press
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
