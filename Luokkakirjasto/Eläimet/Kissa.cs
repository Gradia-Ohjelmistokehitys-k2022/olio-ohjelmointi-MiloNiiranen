using System;

namespace Eläimet
{
    public class Kissa : Elain
    {



        public class Kissa : Elain
        {
            string _kehräys;

            public Kissa(string voice) : base(10)
            {
                _kehräys = voice;
            }

            public Kissa(int age, string name, bool carnivore, string voice) : base(name, age, carnivore)
            {
                _kehräys = voice;
            }

            public void kehraa()
            {
                Console.WriteLine(_kehräys + _kehräys);
            }

        }
    }
}