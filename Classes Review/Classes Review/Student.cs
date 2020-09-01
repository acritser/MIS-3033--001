using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Review
{
    class Student //nameing the class
    {
        public string name { get; set; }  //declaring the variables 

        public int id { get; set; } // take away the set and it makes it to where they cannot set the specific name.

        public  static int totalStudents { get; set; }

        public DateTime enrollDate { get; set; }

        //creating methods

        public Student(string name, int id)
        {
            this.name = name;                // green lines there is a variable called name
            this.id = id;                // in the top class so you have to put this. in front of the variable 
            enrollDate = DateTime.Now;  //names so that it knows to only refernce this name in this class

        }

        public Student()
        {
            name = string.Empty;
            id = -1;    //by default all of our student are going to have an empty string for name until it is inouted 
            enrollDate = DateTime.Now;  //have to call this in eahc method
      
        }

        public string getName()  //get name from the user
        {
            return name;
        }

        public int getId()  // to return the id 
        {
            return id;
        }

        public void setName(string name)  // to set name 
        {
            this.name = name;
        }

        public override string ToString()  //to override
        {
            return ("programming is so much fun!");
        }

    }
} // this is from the classes slides student from slide 17
