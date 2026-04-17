using System;

class Osoba
{
    private int id;
    private string imie;

    public static int liczbaInstancji = 0;

    public Osoba()
    {
        id = 0;
        imie = "";
        liczbaInstancji++;
    }

    public Osoba(int id, string imie)
    {
        this.id = id;
        this.imie = imie;
        liczbaInstancji++;
    }

    public Osoba(Osoba inna)
    {
        this.id = inna.id;
        this.imie = inna.imie;
        liczbaInstancji++;
    }

    public void Przywitaj(string inneImie)
    {
        if (string.IsNullOrEmpty(imie))
        {
            Console.WriteLine("Brak danych");
        }
        else
        {
            Console.WriteLine("Cześć " + inneImie + ", mam na imię " + imie);
        }
    }
}

class Program
{
    static void Main()
    {
        Osoba o1 = new Osoba();
        Osoba o2 = new Osoba(1, "Jan");
        Osoba o3 = new Osoba(o2);

        o1.Przywitaj("Anna");
        o2.Przywitaj("Anna");
        o3.Przywitaj("Piotr");

        Console.WriteLine("Liczba instancji: " + Osoba.liczbaInstancji);
    }
}
