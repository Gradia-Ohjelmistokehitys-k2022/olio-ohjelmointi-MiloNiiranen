using System;

namespace Velka
{
    class Program
    {
        static void Main(string[] args)
        {
            Velka mara = new Velka(2000, 0.07);
            mara.TulostaSaldo();
            mara.OdotaVuosi();
            mara.TulostaSaldo();
        }
    }
}