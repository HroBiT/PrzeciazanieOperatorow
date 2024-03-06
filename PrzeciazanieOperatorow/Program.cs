using PrzeciazanieOperatorow;
using System;

class Program
{
    static void Main(string[] args)
    {
        Produkt produkt1 = new Produkt { Nazwa = "Laptop", Cena = 2500, Ilość = 5 };
        Produkt produkt2 = new Produkt { Nazwa = "Smartphone", Cena = 1500, Ilość = 10 };

        Console.WriteLine("Informacje o produkcie 1:");
        produkt1.Informacje();

        Console.WriteLine("Informacje o produkcie 2:");
        produkt2.Informacje();

        Console.WriteLine("Czy ceny produktów są równe?: " + (produkt1 == produkt2));
        Console.WriteLine("Czy ceny produktów są różne?: " + (produkt1 != produkt2));
        Console.WriteLine("Czy cena produktu 1 jest mniejsza od ceny produktu 2?: " + (produkt1 < produkt2));
        Console.WriteLine("Czy cena produktu 1 jest większa od ceny produktu 2?: " + (produkt1 > produkt2));

        Console.WriteLine("Inkrementacja ilości produktu 1:");
        ++produkt1;
        produkt1.Informacje();

        Console.WriteLine("Dekrementacja ilości produktu 2:");
        --produkt2;
        produkt2.Informacje();

        magazyn magazyn = new magazyn { Nazwa = "Sklep Elektroniczny" };
        magazyn.Produkty.Add(produkt1);
        magazyn.Produkty.Add(produkt2);

        Console.WriteLine("Produkty w magazynie:");
        magazyn.WyświetlProdukty();

        Console.WriteLine("Sortowanie produktów według ceny:");
        magazyn.SortujProdukty();
        magazyn.WyświetlProdukty();

        Macierz a = new Macierz(2, 2);
        a[0, 0] = 1;
        a[0, 1] = 2;
        a[1, 0] = 3;
        a[1, 1] = 4;

        Macierz b = new Macierz(2, 2);
        b[0, 0] = 5;
        b[0, 1] = 6;
        b[1, 0] = 7;
        b[1, 1] = 8;

        Macierz c;

        Console.WriteLine("Macierz a:");
        WyswietlMacierz(a);

        Console.WriteLine("Macierz b:");
        WyswietlMacierz(b);

        Console.WriteLine("Dodawanie macierzy:");
        c = a + b;
        WyswietlMacierz(c);

        Console.WriteLine("Odejmowanie macierzy:");
        c = a - b;
        WyswietlMacierz(c);

        Console.WriteLine("Mnożenie macierzy:");
        c = a * b;
        WyswietlMacierz(c);

        Console.WriteLine("Inkrementacja macierzy a:");
        ++a;
        WyswietlMacierz(a);

        Console.WriteLine("Dekrementacja macierzy b:");
        --b;
        WyswietlMacierz(b);
    }

    static void WyswietlMacierz(Macierz macierz)
    {
        for (int i = 0; i < macierz.GetLength(0); i++)
        {
            for (int j = 0; j < macierz.GetLength(1); j++)
            {
                Console.Write(macierz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}