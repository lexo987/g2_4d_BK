class Programa
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
