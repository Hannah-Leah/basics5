using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightSwitcherEvent
{
    delegate void SwitchFlippedHandler(bool zustand);
    internal class Switcher
    {
        private bool _zustand = false;
        // Event
        // ist nach aussen für clients sichtbar
        // Clients können sich an/abmelden 
        internal event SwitchFlippedHandler SwitchFlipped;

        // Ausloesemethode 

        protected virtual void OnSwitchFlipped()
        {
            // nur wenn clients angemeldet sind erfolgt ein Aufruf der Methode

            if (SwitchFlipped != null)
            {

                // Aufruf der Delegates
                SwitchFlipped(_zustand);

            }
        }

        internal void RemoveAllEvents()
        {
            SwitchFlipped = null;
        }

        internal void press()
        {
            _zustand = !_zustand;

            //Ausgabe 
            Console.WriteLine($"Schalter ist jetzt {(_zustand ? "On":"Off")}");

            // call vom Event
            OnSwitchFlipped();
        }

    }
} 
