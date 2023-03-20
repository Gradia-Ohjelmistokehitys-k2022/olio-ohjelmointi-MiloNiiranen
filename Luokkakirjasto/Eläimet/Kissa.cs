using System;

namespace Elaimet
{
        public class Kissa : Nisakkaat
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