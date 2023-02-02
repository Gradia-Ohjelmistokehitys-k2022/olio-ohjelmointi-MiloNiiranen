using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public class Kissa
{
    private int ika;
    public string Nimi;

    public Kissa()
    {
        this.ika = 1;
        this.Nimi = "Kake";
    }
    public Kissa(int ika, string nimi)
    {
        this.ika = ika;
        this.Nimi = nimi;
    }
    public string PalautaKissanNimi()
    {
        return Nimi;
    }

    public int PalautaKissanIka()
    {
        return ika;
    }
    public bool AsetaKissanIka(int age)
    {
        if (age < 0)
        {
            return false;
        }
        else
        {
            ika = age;
            return true;
        }
    }
    public bool AsetaKissanNimi(string uusinimi)
    {
        string pienennetty = uusinimi.ToUpper();
        if (pienennetty != "HILDA")
        {
            uusinimi = Nimi;
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string ToString()
    {
        return "Kissan nimi on " + Nimi + " ja hän on " + ika + " vuotias";
    }

}
