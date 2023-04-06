using System;
using System.Security.Cryptography;

namespace Elaimet
{
    public class Kissa : Nisakkaat
    {
        string _kehräys;
        private int _ika = 0;
        private string _nimi = "";
        List<Kissa> pennut = new List<Kissa>();


        public Kissa() : base(10)
        {
           
        }

        public Kissa(int age, string name, bool carnivore, string voice) : base(name, age, carnivore)
        {
            _kehräys = voice;
        }

        public void kehraa()
        {
            Console.WriteLine(_kehräys + _kehräys);
        }

        public override bool HyväKuulo()
        {
            return true;
        }
        public void PentujenTiedot()
        {
            Console.WriteLine("Pentuja on: " + pennut.Count);
            Console.WriteLine("Pentujen ikä: " + _ika);
        }
        public string Nimi { get; set; }
        public int Ika { get; set; }
        public List<Kissa> Pennut { get; set; } = new List<Kissa>();
        public Kissa Ema { get; set; }

        public int LisaaPentu()
        {
            Kissa pentu = new Kissa { Ika = 0, Ema = this };
            Pennut.Add(pentu);
            return Pennut.Count;

        }
        

    }
}