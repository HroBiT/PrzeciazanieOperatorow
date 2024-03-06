using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzeciazanieOperatorow
{
    public class Produkt
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }
        public int Ilość { get; set; }

        public void Informacje()
        {
            Console.WriteLine($"Nazwa: {Nazwa}, Cena: {Cena}, Ilość: {Ilość}");
        }

        public static bool operator ==(Produkt a, Produkt b)
        {
            return a.Cena == b.Cena;
        }

        public static bool operator !=(Produkt a, Produkt b)
        {
            return !(a == b);
        }

        public static bool operator <(Produkt a, Produkt b)
        {
            return a.Cena < b.Cena;
        }

        public static bool operator >(Produkt a, Produkt b)
        {
            return a.Cena > b.Cena;
        }

        public static Produkt operator ++(Produkt c)
        {
            c.Ilość++;
            return c;
        }

        public static Produkt operator --(Produkt c)
        {
            c.Ilość--;
            return c;
        }
    }

}
