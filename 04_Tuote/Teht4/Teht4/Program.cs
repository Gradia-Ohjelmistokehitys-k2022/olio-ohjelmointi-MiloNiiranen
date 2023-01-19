using Teht4;

namespace Teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuote banaani = new Tuote(2.6,3,"banaani");
            Tuote omena = new Tuote(3.5, 2, "omena");
            omena.TulostaTuote();
            banaani.TulostaTuote();

        }
    }
}