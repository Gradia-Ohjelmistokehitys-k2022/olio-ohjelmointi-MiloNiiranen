using System;

namespace Teht8
{
     class Program
    {

         static void Main(string[] args)
        {
            Maksukortti kortti = new Maksukortti(5);
            Console.WriteLine(kortti);
            kortti.LataaRahaa(15);
            Console.WriteLine(kortti);
            kortti.LataaRahaa(10);
            Console.WriteLine(kortti);
            kortti.LataaRahaa(200);
            Console.WriteLine(kortti);
        }
    }
}
