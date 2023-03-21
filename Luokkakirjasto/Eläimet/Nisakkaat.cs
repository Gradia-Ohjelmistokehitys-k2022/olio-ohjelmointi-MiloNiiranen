using System;

namespace Elaimet
{
    public class Nisakkaat : Elain
    {
        bool _selkarankainen;
        public Nisakkaat(int maksimiIka) : base(maksimiIka)
        {

        }

        public Nisakkaat(string nimi, int ika, bool lihis) : base(nimi, ika, lihis)
        {

        }

        public bool AsetaSelkarankainen()
        {
            if (_selkarankainen)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool PalautaSelkarankainen()
        {
            return _selkarankainen;
        }
    }
}
