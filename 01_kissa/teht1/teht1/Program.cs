namespace teht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Kissa naapurinKissa = new Kissa();
            Kissa omaKissa = new Kissa(2, "Taneli");
            Console.WriteLine(omaKissa.Nimi);
            Console.WriteLine(naapurinKissa.Nimi);

           
            omaKissa.AsetaKissanIka(5);
            Console.WriteLine(omaKissa.PalautaKissanIka());

            Console.WriteLine(omaKissa.AsetaKissanNimi("joel"));

            Kissa katti = new Kissa();
            Console.WriteLine(katti);
            Console.WriteLine(omaKissa);
                Console.WriteLine(naapurinKissa); 
        }
    }
}