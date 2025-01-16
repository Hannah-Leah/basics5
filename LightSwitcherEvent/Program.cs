namespace LightSwitcherEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Switcher switcher = new Switcher();
            Light deckenLampe = new Light("DeckenLampe");
            // Anmelden beim Event
            switcher.SwitchFlipped += deckenLampe.OnFlipCallBack;
            switcher.press();

            Light stehLampe = new Light("stehLampe");
            // Anmelden für Multievent
            switcher.SwitchFlipped += stehLampe.OnFlipCallBack;

            switcher.press();
            switcher.press();
            // Abmelden vom Event
            switcher.SwitchFlipped -= deckenLampe.OnFlipCallBack;
            switcher.press();
            switcher.press();

            // Fehler? Doppelt anmelden
            switcher.SwitchFlipped += stehLampe.OnFlipCallBack;
            switcher.press();
            switcher.press();

            // Alles abmelden
            switcher.RemoveAllEvents();
            switcher.press();
            switcher.press();
        }
        
    }
}
