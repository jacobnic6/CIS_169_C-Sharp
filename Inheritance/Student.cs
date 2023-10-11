using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Student
    {
        protected string firstName;
        protected string lastName;
        protected DateTime dateOfBirth;
        protected int studentID;

        protected string FirstName { get => firstName; set => firstName = value; }
        protected string LastName { get => lastName; set => lastName = value; }
        protected DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        protected int StudentID { get => studentID; set => studentID = value; }

        // Properties

        // Constructors
        public Student()
        {
            // TODO
        }

        public Student(string fName, string lName, DateTime DOB, int ID)
        {
            FirstName = fName;
            LastName = lName;
            DateOfBirth = DOB;
            StudentID = ID; 
            // TODO
        }
  
        // Add method

        public override string ToString()
        {
            return base.ToString() + "\nName: " + FirstName + " " + LastName + " ID: " + StudentID;
        }

        public virtual string MakeNamePlate()
        {
            return "Last name: " + LastName + ", First name: " + FirstName + ", ID: " + StudentID;
        }

        public int CalculateAge()
        {
            int age = 0;
            age = DateTime.Now.Year - DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
            {
                age = age - 1;
                return age;
            }
            else
            {
                return age;
            }
        }
    }
}
