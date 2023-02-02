using Eläimet;

namespace Teht9
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Eläimet.Kissa koe = new Kissa();
            Console.WriteLine(koe.nimi);
        }
    }
}