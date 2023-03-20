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

        public void AsetaSelkarankainen(bool selkarankainen)
        {
            _selkarankainen = selkarankainen;
        }

        public bool PalautaSelkarankainen()
        {
            if (_selkarankainen)
                return true;

            else
                return false;
        }
    }
}
