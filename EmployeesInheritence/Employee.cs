using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesInheritence
{
    class Employee
    {
        private static int currentEmp;

        protected int ID {  get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee()
        {
            this.ID = 0;
            this.Name = "FName";
            this.FirstName = "LName";
            this.Salary = 0;
        }

        public Employee(string name, string firstName, int salary)
        {
            this.ID = GetNextID();
            this.FirstName = firstName;
            this.Salary = salary;
            this.Name = name;
            
        }

        public virtual void Work()
        {
            Console.WriteLine("{0} {1} is working", Name, FirstName);
        }

        public void Pause()
        {
            Console.WriteLine("{0} {1} is taking a break.", Name, FirstName);
        }

        public int GetNextID()
        {
            return ++currentEmp;
        }
    }
}
