using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DSAAssignment;

namespace DSAAssignmentTests
{
    [TestFixture]
    public class DSATests
    {

        public Student[] studentArray = new Student[10];
        
        [SetUp]
        public void Staging()
        {
            studentArray[0] = new Student("389765", "Archery", new Enrolment(), "Clint Barton", "cbarton@email.com", "0404208170", new Address());
            studentArray[1] = new Student("741610", "Advanced Programming", new Enrolment(), "Tony Stark", "tstark@email.com", "0404738586", new Address());
            studentArray[2] = new Student("923092", "Social Engineering", new Enrolment(), "Natasha Romanoff", "nromanoff@email.com", "0404706861", new Address());
            studentArray[3] = new Student("582901", "Ethics", new Enrolment(), "Steven Rogers", "srogers@email.com", "0404641781", new Address());
            studentArray[4] = new Student("694569", "Electrical Engineering", new Enrolment(), "Thor Odinson", "todinson@email.com", "0404996048", new Address());
            studentArray[5] = new Student("487474", "Chemistry", new Enrolment(), "Bruce Banner", "bbanner@email.com", "0404378800", new Address());
            studentArray[6] = new Student("699187", "Aircraft Design", new Enrolment(), "Sam Wilson", "swilson@email.com", "0404745480", new Address());
            studentArray[7] = new Student("710202", "Critical Thinking", new Enrolment(), "Phil Coulson", "pcoulson@email.com", "0404732617", new Address());
            studentArray[8] = new Student("231129", "Ace Piloting", new Enrolment(), "Carol Danvers", "cdanvers@email.com", "0404668725", new Address());
            studentArray[9] = new Student("467959", "Quantum Physics", new Enrolment(), "Janet van Dyne", "jvandyne@email.com", "0404321926", new Address());
        }

        [Test]
        public void FindExistingLinear()
        {
            Student search = studentArray[3];
            int result = Utility.LinearSearchArray(studentArray, search);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void FindNonExistingLinear()
        {
            Student search = new Student("123456", "Art & Design", new Enrolment(), "James Duffman", "email@email.com", "0812345678", new Address());
            int result = Utility.LinearSearchArray(studentArray, search);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void FindExistingBinary()
        {
            Student search = studentArray[3];
            Array.Sort(studentArray);
            int result = Utility.BinarySearchArray(studentArray, search);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void FindNonExistingBinary()
        {
            Student search = new Student("123456", "Art & Design", new Enrolment(), "James Duffman", "email@email.com", "0812345678", new Address());
            Array.Sort(studentArray);
            int result = Utility.BinarySearchArray(studentArray, search);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void TestSortingAscending()
        {
            Utility.SortAscending(studentArray);
            Assert.AreEqual("231129", studentArray[0].StudentID);
            Assert.AreEqual("923092", studentArray[9].StudentID);
        }

        [Test]
        public void TestSortingDescending()
        {
            Utility.SortDescending(studentArray);
            Assert.AreEqual("923092", studentArray[0].StudentID);
            Assert.AreEqual("231129", studentArray[9].StudentID);
        }
    }
}
