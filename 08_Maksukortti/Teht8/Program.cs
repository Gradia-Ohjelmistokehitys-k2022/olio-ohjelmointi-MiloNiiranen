using System;

namespace Teht8
{
    class Program
    {

        static void Main(string[] args)
        {
            Maksukortti Pekkakortti = new Maksukortti(20);
            Maksukortti Mattikortti = new Maksukortti(30);

            Pekkakortti.SyoMaukkaasti();
            Mattikortti.SyoEdullisesti();

            Console.WriteLine("Pekan saldo: " + Pekkakortti);
            Console.WriteLine("Matin saldo: " + Mattikortti);

            Pekkakortti.LataaRahaa(20);
            Mattikortti.SyoMaukkaasti();

            Console.WriteLine("Pekan saldo: " + Pekkakortti);
            Console.WriteLine("Matin saldo: " + Mattikortti);

            Pekkakortti.SyoEdullisesti();
            Pekkakortti.SyoEdullisesti();
            Mattikortti.LataaRahaa(50);

            Console.WriteLine("Pekan saldo: " + Pekkakortti);
            Console.WriteLine("Matin saldo: " + Mattikortti);

        }
    }
}
