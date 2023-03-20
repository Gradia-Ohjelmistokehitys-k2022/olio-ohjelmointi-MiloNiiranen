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

        public void AsetaMunii(bool munii)
        {
            _munii = munii;
        }
        public bool PalautaMunii()
        {
            if (true)
                return true;

            else 
                return false;
        }
    }
}
