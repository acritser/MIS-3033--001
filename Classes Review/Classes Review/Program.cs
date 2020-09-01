using System;
using System.Collections.Generic;
using System.Transactions;

namespace Classes_Review
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();
            Student stud1 = new Student();
            //Console.WriteLine($"{stud1.name} has an id of {stud1.id}");
            stud1.setName("Micah");  // the only wasy to et the id is to write a method in Students

            stud1.id = 2;
            students.Add(stud1);

            Student stud2 = new Student("Adam", 1);
            students.Add(stud2);

            foreach (var stud in students)
            {
                Console.WriteLine($"{stud1.name} has an id of {stud1.id}");
            }
        }

        //Console.WriteLine($"{stud2.name} has an id of {stud2.id}");
        //this shows the full info on the screen

        DateTime current = DateTime.Now;
        DateTime past = Convert.ToDateTime("1/1/2020");

       
           



    }
    }  
