using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LightSwitcherEvent
{
    internal class Light
    {
        internal string Name { get; set; }
        internal Light(string name)
        {
            this.Name = name;
        }
        // Methode mit der wir unser Licht beim Event anmelden

        internal void OnFlipCallBack(bool lightning)
        {
            if (lightning)
            {
                Console.WriteLine($"Licht: {Name} Leuchtet");
            }
            else
            {
                Console.WriteLine($"Licht: {Name} Leuchtet nicht");
            }
        }
    }
}
