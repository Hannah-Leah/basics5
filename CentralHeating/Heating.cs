using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CentralHeating
{
    internal class Heating
    {
        internal void OnCallBack(bool heating, int temperature)
        {
            if (heating)
            {
                Console.WriteLine("the heating is on.");
            }
            else
            {
                Console.WriteLine("the heating is off.");
            }
        }
    }
}
