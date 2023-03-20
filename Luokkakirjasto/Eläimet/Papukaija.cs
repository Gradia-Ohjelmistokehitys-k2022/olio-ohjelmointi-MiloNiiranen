using System;

namespace Elaimet
{
    public class Papukaija : Linnut
    {
        string _rääkkyy;
        public Papukaija(string voice) : base(9)
        {
            _rääkkyy = voice;
        }

        public Papukaija(int age, string name, bool carnivore, string voice) : base(name, age, carnivore)
        {
            _rääkkyy = voice;

        }
        
    }
}
