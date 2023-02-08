using Eläimet;

Kissa uusikissa = new Kissa("hrrrr");
Koira uusikoira = new Koira("Wuh ");
Koira pepe = new Koira("Hau! ");



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