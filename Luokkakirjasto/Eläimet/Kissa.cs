using System;

namespace Eläimet
{
    public class Kissa:Elain
    {
        public Kissa() : base(10)
        {

        }

        public Kissa(int age, string name, bool carnivore) : base( name, age, carnivore)
        {
            
        }
    }
}
