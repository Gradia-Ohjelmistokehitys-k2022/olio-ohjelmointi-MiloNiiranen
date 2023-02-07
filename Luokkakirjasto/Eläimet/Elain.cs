using System;

namespace Eläimet
{
    public class Elain
    {
        private string _nimi;
        private int _ika;
        private bool _onlihansyoja;
        public bool PalautaOnLihanSyoja()
        {
            return _onlihansyoja;
        }
    
        public string PalautaNimi()
        {
            return _nimi;
        }

        public int PalautaIka()
        {
            return _ika;
        }
        public bool AsetaIka(int age)
        {
            if (age < 0)
            {
                return false;
            }
            else
            {
                _ika = age;
                return true;
            }
        }
        public void AsetaNimi(string uusinimi)
        {
            uusinimi = _nimi;
    
        }

        public override string ToString()
        {
            if (_onlihansyoja)
            {
                return " nimi on " + _nimi + " ja hän on " + _ika + " vuotias ja syö lihaa";
            }

            else
            {
                return " nimi on " + _nimi + " ja hän on " + _ika + " vuotias ja syö jotain";
            }
        }
        public void AsetaOnLihansyoja()
        {

        }

    }
}
