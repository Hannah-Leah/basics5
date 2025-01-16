using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralHeating
{
    delegate void SwitchHeatingHandler(bool status);
    internal class Radiator
    {
        private bool _status = false;

        internal event SwitchHeatingHandler SwitchFlipped;

        protected virtual void OnSwitchFlipped()
        {

            if (SwitchFlipped != null)
            {
               SwitchFlipped(_status);

            }
        }

        internal void press()
        {
            _status = !_status;
            
            Console.WriteLine($"The switch is now {(_status ? "On" : "Off")}");

            // call vom Event
            OnSwitchFlipped();
        }
    }
}
