﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Jim", "Art", 3.6);
            Student student2 = new Student("Bob", "IT", 2.8);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
        }

       
     

    }
}