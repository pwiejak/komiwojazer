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
            List<Osobnik> dzieci = new List<Osobnik>();
            List<Osobnik> wybraneOsobniki = wybierzOsobnikowDoKrzyzowania(populacja);
            for (int i = 0; i < populacja.Count; i=i+2)
            {
                dzieci = krzyzujOsobniki(wybraneOsobniki[i], wybraneOsobniki[i+1]);
                kolejnePokolenie.Add(dzieci[0]);
                kolejnePokolenie.Add(dzieci[1]);
            }
            
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
            System.Random x = new Random();
            int przedzialA = losujLiczbe(rodzicA.listaMiast.Count,x);
            int przedzialB = losujLiczbe(rodzicA.listaMiast.Count, x);
            while (przedzialA.Equals(przedzialB))
            {
                przedzialA = losujLiczbe(rodzicA.listaMiast.Count, x);
            }
            if (przedzialA > przedzialB)
            { 
                int temp = przedzialB;
                przedzialB = przedzialA;
                przedzialA = temp;
            }

            List<Miasto> listaMiastOdwiedzonych1 = new List<Miasto>();
            List<Miasto> listaMiast1 = new List<Miasto>();
            for (int i = 0 ; i < rodzicA.odwiedzaneMiasta.Count ; i++)
            {
                Miasto mLista = rodzicA.listaMiast[i];
                Miasto mOdwiedzone = rodzicA.odwiedzaneMiasta[i];
                listaMiast1.Add(mLista);
                listaMiastOdwiedzonych1.Add(mOdwiedzone);
            }

            List<Miasto> listaMiastOdwiedzonych2 = new List<Miasto>();
            List<Miasto> listaMiast2 = new List<Miasto>();
            for (int i = 0; i < rodzicB.odwiedzaneMiasta.Count; i++)
            {
                Miasto mLista = rodzicB.listaMiast[i];
                Miasto mOdwiedzone = rodzicB.odwiedzaneMiasta[i];
                listaMiast2.Add(mLista);
                listaMiastOdwiedzonych2.Add(mOdwiedzone);
            }
            
            List<Osobnik> dzieci = new List<Osobnik>();

            

            Osobnik rodzic1 = new Osobnik();
            rodzic1.odwiedzaneMiasta = listaMiastOdwiedzonych1;
            rodzic1.listaMiast = listaMiast1;

            Osobnik rodzic2 = new Osobnik();
            rodzic2.odwiedzaneMiasta = listaMiastOdwiedzonych2;
            rodzic2.listaMiast = listaMiast2;
           
            Osobnik dziecko1 = rodzic1;
            Osobnik dziecko2 = rodzic2;
            

            for (int i = 0; i < dziecko1.listaMiast.Count; i++)
            {
                dziecko1.odwiedzaneMiasta[i] = null;
            }
            for (int i = 0; i < dziecko2.listaMiast.Count; i++)
            {
                dziecko2.odwiedzaneMiasta[i] = null;
            }
            for (int i = przedzialA; i < przedzialB; i++)
            {
                dziecko1.odwiedzaneMiasta[i] = rodzicB.odwiedzaneMiasta[i];
                dziecko2.odwiedzaneMiasta[i] = rodzicA.odwiedzaneMiasta[i];
            }
            int przedzial = przedzialB;
            for (int j = 0; j < listaMiast.Count; j++)
            {
                if (dziecko1.odwiedzaneMiasta[j] == null)
                { 
                    while(dziecko1.odwiedzaneMiasta.Contains(rodzicA.odwiedzaneMiasta[przedzialB]))
                    {
                        if(przedzialB < rodzicA.odwiedzaneMiasta.Count - 1)
                            przedzialB++;
                        else
                            przedzialB = 0;
                    }
                    dziecko1.odwiedzaneMiasta[j] = rodzicA.odwiedzaneMiasta[przedzialB];
                }

                if (dziecko2.odwiedzaneMiasta[j] == null)
                {
                    while (dziecko2.odwiedzaneMiasta.Contains(rodzicB.odwiedzaneMiasta[przedzial]))
                    {
                        if (przedzial < rodzicB.odwiedzaneMiasta.Count - 1)
                            przedzial++;
                        else
                            przedzial = 0;
                    }
                    dziecko2.odwiedzaneMiasta[j] = rodzicB.odwiedzaneMiasta[przedzial];
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
