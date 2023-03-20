using Elaimet;

Kissa uusikissa = new Kissa("hrrrr");
Koira uusikoira = new Koira("Wuh ");
Koira pepe = new Koira("Hau! ");

Koira toinenkoira = new Koira("");
Papukaija uusipapukaija = new Papukaija("");

uusipapukaija.AsetaNimi("Kalle");
uusipapukaija.AsetaIka(4);
uusipapukaija.AsetaMunii(false);
uusipapukaija.PalautaMunii();

toinenkoira.AsetaSelkarankainen(false);

pepe.Haukkuu();
uusikoira.Haukkuu();
uusikissa.kehraa();

Console.WriteLine(uusikissa);
Console.WriteLine(uusikoira);

Console.WriteLine(uusikissa.PalautaIka());
Console.WriteLine(uusikoira.PalautaIka());

if (uusikoira.PalautaIka() > uusikissa.PalautaIka())
{
    Console.WriteLine("Koira on vanhempi");
}
else
{
    Console.WriteLine("Kissa on vanhempi");
}

