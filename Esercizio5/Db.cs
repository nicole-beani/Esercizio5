using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Esercizio5
{
    public class Db
    {
        public static List<Product> elencoProdotti;
        public static List<Product> Carrello = new List<Product>();
        public static double TotCarrello;

        public static void addProdotto(Product prodotto)
        {
            elencoProdotti.Add(prodotto);

        }
        public static void addCarrello(Product prodotto)
        {
            Carrello.Add(prodotto);
            TotCarrello += prodotto.Price;

        }

        public static Product getPrd(int id)
        {
            Product prodotto = new Product();

            foreach (var p in elencoProdotti)
            {
                if (p.Id == id)
                {
                    prodotto = p;

                }
            }

            return prodotto;
        }

        public static void deletePrd(int id)
        {
            foreach (var p in Carrello)
            {
                if (p.Id == id)
                {
                    Carrello.Remove(p);
                    TotCarrello -= p.Price;
                    break;
                }
            }
        }

        public static void deleteAll()
        {
            Carrello.Clear();
            TotCarrello = 0;

        }
    }
}