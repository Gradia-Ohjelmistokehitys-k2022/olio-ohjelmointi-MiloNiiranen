using System;

namespace Velka
{
    internal class Velka
    {
        double _saldoAlussa;
        double _korkoProsentti;
        public Velka(double saldoAlussa, double korkoProsentti)
        {
            this._saldoAlussa = saldoAlussa;
            this._korkoProsentti = korkoProsentti;
        }
        public void TulostaSaldo()
        {
            Console.WriteLine(_saldoAlussa);
            Console.WriteLine(_korkoProsentti);
        }
        public void OdotaVuosi()
        {
            Console.WriteLine((_saldoAlussa = _saldoAlussa * (1 + _korkoProsentti)));
        }

    }
}
