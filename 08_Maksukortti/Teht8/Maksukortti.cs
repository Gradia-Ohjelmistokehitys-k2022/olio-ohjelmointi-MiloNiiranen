using System;

namespace Teht8
{
    public class Maksukortti
    {
        private double saldo;
        public Maksukortti(double alkusaldo)
        {
            saldo = alkusaldo;
        }

        public override String ToString()
        {
            return ("Kortilla on rahaa " + saldo + " " + "euroa");
        }
        public void SyoEdullisesti()
        {
            if (saldo >= 2.60)
            {
                saldo = saldo - 2.60;
            }
        }
        public void SyoMaukkaasti()
        {

            if (saldo >= 4.60)
            {
                saldo = saldo - 4.60;
            }
        }
        public void LataaRahaa(double lisätty)
        {
            if (lisätty < 0)
            {
                lisätty = 0;
            }
            saldo = saldo + lisätty;
        }
    }
}