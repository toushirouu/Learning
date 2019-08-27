using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Methods
{
    class Student
    {
        public string name;
        public string major;
        public string paid;
        public double gpa;


        public Student(string aName, string aMajor, string aPaid, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
            paid = aPaid;

        }
        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;

        }

        public bool HasPaid()
        {
            if (paid == "yes" || paid == "Yes" || paid == "YES")
            {
                return true;
            }
            return false;
        }

}
    }
