using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzeciazanieOperatorow
{
    public class magazyn
    {
        public string Nazwa { get; set; }
        public List<Produkt> Produkty { get; set; }

        public magazyn()
        {
            Produkty = new List<Produkt>();
        }

        public void WyświetlProdukty()
        {
            foreach (var produkt in Produkty)
            {
                produkt.Informacje();
            }
        }

        public void SortujProdukty()
        {
            Produkty = Produkty.OrderBy(p => p.Cena).ToList();
        }
    }
}
