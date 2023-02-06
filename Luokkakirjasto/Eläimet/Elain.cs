using System;

namespace Eläimet
{
    public class Elain
    {
        protected string _nimi;
        private int _ika;
        private bool _onlihansyoja;

   
        public Elain(int maksimiIka)
        {
            _ika= Tool.GiveNumber(maksimiIka);
            if (maksimiIka == 10)
            {
                _nimi = "kisu";
            }
            else
            {
                _nimi = "koira";
            }

        }
        public Elain(string nimi, int ika, bool lihis)
        {
            this._ika = ika;
            this._nimi = nimi;
            _onlihansyoja= lihis;
        }


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
