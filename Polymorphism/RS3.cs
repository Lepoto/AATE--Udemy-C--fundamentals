using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class RS3(int hp, string color, string model) : Audi(hp, color, model)
    {
       /* public override void Repair()
        {
            base.Repair();
        }*/
    }
}
