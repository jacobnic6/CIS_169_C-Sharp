using System;

namespace structPractice
{
    class Program
    {
        struct Person
        {
            private string fName;
            private string lName;
            private string email;
            private int phoneNumber;
            private int age;

            public void GetPerson(string a, string b, string c, int d, int e)
            {
                fName = a;
                lName = b;
                email = c;
                phoneNumber = d;
                age = e;

            }

            public void DisplayPerson()
            {
                Console.WriteLine("Person 1 First Name: {0}", fName);
                Console.WriteLine("Person 1 Last Name: {0}", lName);
                Console.WriteLine("Person 1 email: {0}", email);
                Console.WriteLine("Person 1 phone # : {0}", phoneNumber);
                Console.WriteLine("Person 1 age: {0}", age);
               

            }
        }

        

        static void Main(string[] args)
        {
            //•Define a structure, Person that contains

            //•first name

            //•last name

            //•email

            //•phone number

            //•age

            //•Write a method outside of the struc called displayPerson() that

            //•Accepts a parameter of type Person

            //•Returns a string of all the information about that person nicely formatted

            //•In the Main method declare and initiate a person and print of the person’s info

            //Press Shift +Tab to navigate to chat history.

            Person Person1 = new Person();
            

            Person1.GetPerson("Nick", "Jacobs", "abcde@gmail.com", 1234567890, 25);


           

            Person1.DisplayPerson();



        }
    }
}
