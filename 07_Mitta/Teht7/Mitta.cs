﻿using System;

namespace Teht7
{
    internal class Mittari
    {
        private int _mitta;

        public void Lisaa()
        {
            if (_mitta <= 5)
            {
                _mitta = _mitta + 1;
            }
        }
        public void Vahenna()   
        {
            if (_mitta > 0)
            {
                _mitta = _mitta - 1;
            }
        }
        public int Mitta()
        {
            return _mitta;
        }
        public bool Taynna()
        {
            if (_mitta == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
