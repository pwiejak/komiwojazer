using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Komiwojazer1
{
    class Populacja
    {
        public List<Osobnik> generowanaPopulacja;// = new List<Osobnik>();
        public List<Miasto> listaMiast;
        public Populacja(List<Miasto> miasta)
        {
            listaMiast = miasta;
        }

        public List<Osobnik> generujKolejnePokolenie(List<Osobnik> populacja)
        {
            List<Osobnik> kolejnePokolenie = new List<Osobnik>();
            List<Osobnik> wybraneOsobniki = wybierzOsobnikowDoKrzyzowania(populacja);

            return kolejnePokolenie;
        }

        public List<Osobnik> generujLosowa(int rozmiar)
        {
            generowanaPopulacja = new List<Osobnik>();
            for (int i = 0; i < rozmiar; i++)
            {
                Osobnik kolejnyOsobnik = new Osobnik(listaMiast);
                kolejnyOsobnik.generujLosowego();
                generowanaPopulacja.Add(kolejnyOsobnik);
            }

            return generowanaPopulacja;
        }

        public List<Osobnik> wybierzOsobnikowDoKrzyzowania(List<Osobnik> osobnicy)
        {
            //wybieranie osobnikow do krzyzowania metoda turniejowa
            List<Osobnik> noweOsobniki = new List<Osobnik>();
            /*Osobnik wybranyDalej = osobnicy[1];
            for (int k = 0; k < osobnicy.Count; k++)
            {
                if (wybranyDalej.dlugoscTrasy < osobnicy[k].dlugoscTrasy)
                    wybranyDalej = osobnicy[k];
            }*/
            int numerOsobnika;
            for (int i = 0; i < osobnicy.Count; i++)
            {
                Osobnik wybranyDalej = new Osobnik();
                wybranyDalej.dlugoscTrasy = int.MaxValue;
                for (int j = 0; j < 4; j++)
                {
                    numerOsobnika = losujLiczbe(osobnicy.Count);
                    if (wybranyDalej.dlugoscTrasy > osobnicy[numerOsobnika].dlugoscTrasy)
                    {
                        wybranyDalej = osobnicy[numerOsobnika];
                    }
                }
                noweOsobniki.Add(wybranyDalej);
            }
            return noweOsobniki;
        }

        public int losujLiczbe(int max)
        {
            Random losowa = new Random();
            int zwracana;
            zwracana = losowa.Next(0, max);
            return zwracana;
        }
    }
}
