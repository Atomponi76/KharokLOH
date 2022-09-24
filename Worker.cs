using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal abstract class Worker
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }


        public Worker(string name, int age, double salary)
        {
            Console.WriteLine("Worker full c onstructor");
            Name = name;
            Age = age;
            Salary = salary;
        }
        public Worker()
        {
            Console.WriteLine("Worker defoult constructor");
        }

        public abstract double GetResultSalary();
    }
}
