using System;

namespace Elaimet
{
    public class Hevonen:Nisakkaat
    {
        string _ihahaa;
        public Hevonen() : base(8)
        {

        }
        public Hevonen(int age, string name, bool carnivore, string voice) :base(name, age, carnivore)
        {
            _ihahaa = voice;
        }

        public override bool Laukkaa()
        {
            return true;
        }
    }
}
