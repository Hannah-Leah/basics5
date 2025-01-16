using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralHeating
{
    delegate void SwitchHeatingHandler(bool status, int Temperature);
    internal class Radiator
    {
        private bool _status = false;
        private int _temperature;

        internal event SwitchHeatingHandler SwitchFlipped;

        protected virtual void OnSwitchFlipped()
        {

            if (SwitchFlipped != null)
            {
               SwitchFlipped(_status, _temperature );

            }
        }

        internal void press()
        {
            _status = !_status;
            _temperature = 23;

            Console.WriteLine($"The switch is now {(_status ? "On" : "Off")}.");
            if (_status)
            {
                Console.WriteLine($"Current temperature changed to: {_temperature} C");
            }
            else
            {
                _temperature = 10;
                Console.WriteLine($"Current temperature: {_temperature} C");
            }
            // call vom Event
            OnSwitchFlipped();
        }
    }
}
