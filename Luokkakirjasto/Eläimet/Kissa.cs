using System;

namespace Eläimet
{
<<<<<<< HEAD
    public class Kissa:Elain
    {
        
=======

    public class Kissa:Elain
    {
        string _kehräys;

        public Kissa(string voice) : base(10)
        {
            _kehräys = voice;
        }

        public Kissa(int age, string name, bool carnivore, string voice) : base( name, age, carnivore)
        {
            _kehräys = voice;
        }

        public void kehraa()
        {
            Console.WriteLine(_kehräys + _kehräys);
        }
>>>>>>> c76d2422d74d6205e047b56cb99873de86a87024
    }
}