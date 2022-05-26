using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_assignment3
{
    public abstract class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private List<string> address = new List<string>();
        public List<string> Address
            {
            get { return address; } 
            private set { address = value; }
        } 

        public void Add_address(string AddressStr)
        {
            address.Add(AddressStr);
        }

        private DateTime cur= DateTime.Now;
        private int experience;
        public int Experience
            { get { return experience; } 
            private set { experience = value; } }

        private DateTime join;
        public void Join(string str)
        {
            join = DateTime.Parse(str);
            experience = cur.Year - join.Year;
        }

        public virtual double Calculate()
        {
            return Experience;
        }
        
    }


    public class Course
    {
        public string Name { get; set; }
        public char Grade { get; set; }

        public List<String> students = new List<String>();
        public Course(string name, char grade)
        {
            Name = name;
            Grade = grade;
        }

        public void AddList(string nameStudent)
        {
            students.Add(nameStudent);
        }
    }

    public class Department
    {
        public string Head { get; set; }
        public string[] CourseList { get; set; }

        public double Budget { get; set; }

    }

    public class Student : Person
    {
        private List<Course> cos = new List<Course>();
        public double gpa = 0.0;

        public void AddCourse(Course c)
        {
            cos.Add(c);

        }


        public override double Calculate()
        {
            int temp=0;
            foreach(Course c in cos)
            {
                temp++;
                switch(c.Grade)
                {
                    case 'A':
                        gpa += 4.0;
                        break;
                    case 'B':
                        gpa += 3.0;
                        break;
                    case 'C':
                        gpa += 2.0;
                        break;
                    case 'D':
                        gpa += 1.0;
                        break;
                    default:
                        gpa += 0.0;
                        break;
                }
            }
            return gpa/temp;
        }

    }

    public class Instructor : Person
    {
        public Department Dp { get; set; }
        public override double Calculate()
        {
            if (Experience>=10)
            {
                return Experience + Experience * 0.3;
            }else
            {
                return Experience * 1.0;
            }      
        }

    }


}
