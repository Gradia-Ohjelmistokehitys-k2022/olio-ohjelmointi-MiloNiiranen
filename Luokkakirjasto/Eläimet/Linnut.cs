using System;

namespace Elaimet
{
    public class Linnut : Elain
    {
        bool _munii;

        public Linnut(int maksimiIka) : base(maksimiIka)
        {

        }

        public Linnut(string nimi, int ika, bool lihis) : base(nimi, ika, lihis)
        {

        }

        public bool AsetaMunii()
        {
            if (_munii)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool PalautaMunii()
        {
            return _munii;
        }
    }
}
