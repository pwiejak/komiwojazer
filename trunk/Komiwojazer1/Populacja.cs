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
            krzyzujOsobniki(wybraneOsobniki[1], wybraneOsobniki[2]);
            return kolejnePokolenie;
        }

        public List<Osobnik> generujLosowa(int rozmiar)
        {
            generowanaPopulacja = new List<Osobnik>();
            Random generator = new Random();
            for (int i = 0; i < rozmiar; i++)
            {
                Osobnik kolejnyOsobnik = new Osobnik(listaMiast);
                kolejnyOsobnik.generujLosowego(generator);
                generowanaPopulacja.Add(kolejnyOsobnik);
            }

            return generowanaPopulacja;
        }

        public List<Osobnik> krzyzujOsobniki(Osobnik rodzicA, Osobnik rodzicB)
        {
            List<Osobnik> dzieci = new List<Osobnik>();
            Osobnik rodzic1 = new Osobnik();
            rodzic1 = rodzicA;
            Osobnik rodzic2 = new Osobnik();
            rodzic2 = rodzicB;
            Osobnik dziecko1 = new Osobnik();
            dziecko1 = rodzic1;
            Osobnik dziecko2 = new Osobnik();
            dziecko2 = rodzic2;
            int przedzial1, przedzial2;
            przedzial1 = rodzic1.listaMiast.Count / 3;
            przedzial2 = przedzial1 * 2;
            for (int i = przedzial1; i < przedzial2; i++)
            {
                dziecko1.odwiedzaneMiasta[i] = rodzic2.odwiedzaneMiasta[i];
                dziecko2.odwiedzaneMiasta[i] = rodzic1.odwiedzaneMiasta[i];
            }

            for (int j = 0; j < listaMiast.Count; j++)
            {
                if (dziecko1.odwiedzaneMiasta[j] != null)
                {
                    for (int k = 0; k < listaMiast.Count; k++)
                    {
                        if (!(dziecko1.odwiedzaneMiasta.Contains(rodzic1.odwiedzaneMiasta[k])))
                        {
                            dziecko1.odwiedzaneMiasta[k] = rodzic1.listaMiast[k];
                        }
                    }
                }

                if (dziecko2.odwiedzaneMiasta[j] != null)
                {
                    for (int k = 0; k < listaMiast.Count; k++)
                    {
                        if (!(dziecko2.odwiedzaneMiasta.Contains(rodzic2.odwiedzaneMiasta[k])))
                        {
                            dziecko1.odwiedzaneMiasta[k] =  rodzic1.odwiedzaneMiasta[k];
                        }
                    }
                }
            }
            dziecko1.liczTrase(dziecko1.odwiedzaneMiasta);
            dziecko2.liczTrase(dziecko2.odwiedzaneMiasta);
            dzieci.Add(dziecko1);
            dzieci.Add(dziecko2);

            return dzieci;
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
            Random seed = new Random();
            
            for (int i = 0; i < osobnicy.Count; i++)
            {
                Osobnik wybranyDalej = new Osobnik();
                wybranyDalej.dlugoscTrasy = int.MaxValue;
                for (int j = 0; j < 4; j++)
                {
                    numerOsobnika = losujLiczbe(osobnicy.Count, seed);
                    if (wybranyDalej.dlugoscTrasy > osobnicy[numerOsobnika].dlugoscTrasy)
                    {
                        wybranyDalej = osobnicy[numerOsobnika];
                    }
                }
                noweOsobniki.Add(wybranyDalej);
                
            }
            return noweOsobniki;
        }
        
        public int losujLiczbe(int max, Random seed)
        {
            return seed.Next(0, max);
        }
 
    }
}
