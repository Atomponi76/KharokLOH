using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Manager : Worker
    {
        public int ClientCount { get; set; }

        public Manager(string name, int age, double salary,int clientCount) 
            : base(name,age,salary)
        {
            Console.WriteLine("manager full constructor");
            ClientCount = clientCount;
        }
        public Manager() : base()
        {
            Console.WriteLine("Manager defoult constructer");
        }

        public override double GetResultSalary()
        {
            return Salary * ClientCount;
        }
    }
}
