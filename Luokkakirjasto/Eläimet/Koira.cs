using System;

namespace Elaimet
{
    public class Koira:Nisakkaat
    {
        string _haukku;                                         

        

        public Koira() : base(15)
        {
          
        }

        public Koira(int age, string name, bool carnivore, string voice) : base(name, age, carnivore)
        {
            _haukku = voice;
        }

        public void Haukkuu()
        {
            Console.WriteLine(_haukku);
        }
        public void Aantele()
        {
            Haukkuu();
        }

        public override bool HyväHajuaisti()
        {
            return true;
        }
    }
}
