using Elaimet;

internal class Program
{
    private static void Main(string[] args)
    {
        Kissa uudempikissa = new Kissa("hrrr ");
        uudempikissa.AsetaNimi("Norbelo");
        uudempikissa.AsetaIka(8);
        uudempikissa.PalautaOnLihanSyoja();

        Console.WriteLine(uudempikissa);
        uudempikissa.kehraa();

        Koira uudempikoira = new Koira("Hau! ");
        uudempikoira.AsetaNimi("Nobo");
        uudempikoira.AsetaIka(11);
        uudempikoira.PalautaOnLihanSyoja();

        Console.WriteLine(uudempikoira);
        uudempikoira.Haukkuu();

        uudempikoira.Aantele();
    }
}

