using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesInheritence
{
    class Boss : Employee
    {
        public string CompanyCar { get; set; }

        public Boss()
        {
            
        }

        public Boss(string name, string firstname, int salary, string companyCar) : base(name, firstname, salary)
        {
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("{0} is the CEO, Founder of SquadShaperDesigns.", Name);
        }
    }
}
