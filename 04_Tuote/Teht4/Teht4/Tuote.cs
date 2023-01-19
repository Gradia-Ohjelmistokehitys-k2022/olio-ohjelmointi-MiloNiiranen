using System;
namespace Teht4
{
    internal class Tuote
    {
        double hintaAlussa;
        int maaraAlussa;
        string nimiAlussa;

        public Tuote(double hintaAlussa, int maaraAlussa, string nimiAlussa)
        {
            this.hintaAlussa = hintaAlussa;
            this.maaraAlussa = maaraAlussa;
            this.nimiAlussa = nimiAlussa;
        }

        public void TulostaTuote()
        {
            Console.WriteLine(nimiAlussa + "hinta" + hintaAlussa + maaraAlussa + "kpl");
        }
    }
}
