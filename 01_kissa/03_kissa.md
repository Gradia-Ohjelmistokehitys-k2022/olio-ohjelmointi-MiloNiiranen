## Kissa: Override ToString()

Kaikki luokat perityvät Object luokasta, jolloin niillä on Tostring() metodi. ToString() metodi palauttaa tekstimuotoisen esityksen oliosta. "Override" määritteen avulla voimme korvata perityn metodin itse määritetyllä.

Lue ohje: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-override-the-tostring-method

Aseta Kissa luokalle ToString() metodi joka toimii alla olevan esimerkin mukaan:
```c#
Kissa katti = new Kissa();
Console.WriteLine(katti); 
```
Esimerkkituloste:

Kissa: Miuku, ikä 0.
