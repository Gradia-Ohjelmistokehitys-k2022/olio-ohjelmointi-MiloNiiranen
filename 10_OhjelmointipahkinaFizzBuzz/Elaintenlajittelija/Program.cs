using System;
    
Console.WriteLine("Montako eläintä luodaan");
int luku = int.Parse(Console.ReadLine());


for (int i = 0; i <= luku; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine("Kissa");
    }
    else if (i % 3 == 1)
    {
        Console.WriteLine("Koira");
    }
    else if (i % 3 == 2)
    {
        Console.WriteLine("Papukaija");
    }
    else if(i % 4 == 0)
    {
        Console.WriteLine("Hevonen");
    }
}

