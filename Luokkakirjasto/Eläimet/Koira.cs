using System;

namespace Eläimet
{
    public class Koira:Elain
    {
        string _haukku;


        public Koira(string voice) : base(15)
        {
           _haukku=voice;
        }

        public Koira(int age, string name, bool carnivore, string voice) : base(name, age, carnivore)
        {
            _haukku= voice;
        }

        public void Haukkuu()
        {
            Console.WriteLine(_haukku + _haukku);
        }
    }
}
