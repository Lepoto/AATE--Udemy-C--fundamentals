using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    internal class Appliances
    {
        public bool isOn;
        public string brandName;

        public Appliances(bool isOn, string brand)
        {
            this.isOn = isOn;
            this.brandName = brand;
        }


        public void SwitchOn()
        {
            isOn = true;
        }

        public void SwitchOff()
        {
            isOn = false;
        }

    }
}
