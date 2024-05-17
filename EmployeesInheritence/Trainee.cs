using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesInheritence
{
    class Trainee : Employee
    {
        public int WorkHours { get; set; }
        public int SchoolHours { get; set; }
        public Trainee()
        {
            
        }

        public Trainee(string name, string firstName, int salary, int workHours, int schoolHours): base(name, firstName, salary)
        {
            this.WorkHours = workHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("I'm learning for {0} hours", SchoolHours);
        }

        public override void Work()
        {
            Console.WriteLine("{0} work for {1} hours",Name, WorkHours);
        }
    }
}
