using System;

namespace Elaimet
{
    public class Papukaija : Linnut
    {
        string _rääkkyy;
        public Papukaija() : base(9)
        {
            
        }

        public Papukaija(int age, string name, bool carnivore, string voice) : base(name, age, carnivore)
        {
            _rääkkyy = voice;

        }

        public override bool OsaaLentää()
        {
            return true;
        }

    }
}
