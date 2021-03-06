﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program16
{
    class Program
    {
        public class Person
        {
            protected string firstName;
            protected string lastName;

            public Person(string first, string last)
            {
                firstName = first;
                lastName = last;
            }

            //FirstName property
            public string FirstName { get { return firstName; } set { firstName = value; } }

            //LastName property
            public string LastName { get { return lastName; } set { lastName = value; } }

            public virtual void Introduction()
            {
                Console.WriteLine("I'm {0} {1}.", firstName, lastName);
            }
        }

        public class Student : Person
        {
            protected int studentID;

            public Student(string first, string last, int id) : base(first, last)
            {
                studentID = id;
            }

            //StudentID property
            public int StudentID { get { return studentID; } set { studentID = value; } }

            //The "new" keyword tells C# that the hiding of methods is intentional 
            //It's better to override than hide!
            public override void Introduction()
            {
                //Call the base class methods first
                base.Introduction();

                Console.WriteLine($"My student ID is: {StudentID}.");
            }
        }

        static void Main(string[] args)
        {
            //Note:
            //1. A subclass doesn’t have to inherit every single method from the base class. 
            //2. A subclass can inherit the essence of the base class method while implementing the details differently.

            Person person1 = new Person("Winnie", "Li");
            person1.Introduction();
            Console.WriteLine();

            Student student1 = new Student("Iris", "Huang", 1810009);
            student1.Introduction();
            Console.WriteLine();
            
        }
    }
}
