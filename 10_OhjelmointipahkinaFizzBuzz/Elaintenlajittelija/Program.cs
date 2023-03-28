using Elaimet;

static string GenerateName(int pituus)
{
    Random r = new Random();
    string[] konsonantit = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
    string[] vokaalit = { "a", "e", "i", "o", "u", "ae", "y" };
    string Nimi = "";
    Nimi += konsonantit[r.Next(konsonantit.Length)].ToUpper();
    Nimi += vokaalit[r.Next(vokaalit.Length)];
    int b = 2;
    while (b < pituus)
    {
        Nimi += konsonantit[r.Next(konsonantit.Length)];
        b++;
        Nimi += vokaalit[r.Next(vokaalit.Length)];
        b++;
    }

    return Nimi;


}
Random random = new Random();

Console.WriteLine("montako eläintä luodaan");
int luku = int.Parse(Console.ReadLine());
List<Elain> lista = new List<Elain>();


for (int i = 0; i <= luku; i++)
{

    if (i % 3 == 0)
    {
        Elain e;
        e = new Kissa();
        e.AsetaNimi(GenerateName(10));
        e.AsetaIka(random.Next(1, 50));
        lista.Add(e);
    }

    else if (i % 3 == 1)
    {
        Elain e;
        e = new Koira();
        e.AsetaNimi(GenerateName(4));
        e.AsetaIka(random.Next(1, 50));
        lista.Add(e);
    }

    else
    {
        Elain e;
        e = new Papukaija();
        e.AsetaNimi(GenerateName(30));
        e.AsetaIka(random.Next(1, 50));
        lista.Add(e);
    }
}

List<Elain> el = new List<Elain>();

int j = 0;
foreach (Elain elain in lista)
{

    j++;
    if (j % 4 == 0)
    {
        Elain e;
        e = new Hevonen();
        e.AsetaNimi(GenerateName(10));
        e.AsetaIka(random.Next(1, 50));
        el.Add(e);
        continue;
    }
    el.Add(elain);
}
foreach (Elain elain in el)
{
    Console.WriteLine("Elaimen tyyppi on {0}", elain.GetType());
    Console.WriteLine("Elaimen nimi on {0}", elain.PalautaNimi());
    Console.WriteLine("Elaimen ika on {0}", elain.PalautaIka());
    Console.WriteLine("Eläimellä on hyvä kuulo {0}", elain.HyväKuulo());
    Console.WriteLine("Eläimellä on hyvä hajuaisti {0}", elain.HyväHajuaisti());
    Console.WriteLine("Eläin osaa lentää {0}", elain.OsaaLentää());
    Console.WriteLine("Elain laukkaa {0}", elain.Laukkaa());
}






