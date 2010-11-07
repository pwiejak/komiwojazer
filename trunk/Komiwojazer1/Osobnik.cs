using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Komiwojazer1
{
    class Osobnik
    {
        public List<Miasto> odwiedzaneMiasta;// = new List<Miasto>();
        public List<Miasto> listaMiast;
        public int dlugoscTrasy;

        public Osobnik(List<Miasto> miasta)
        {
            listaMiast = miasta;
        }

        public Osobnik()
        {

        }

        public void generujLosowego(Random generator)
        {
            List<int> numeryMiast = new List<int>();
            List<Miasto> pomocniczaLista = new List<Miasto>(listaMiast);
            //pomocniczaLista = listaMiast;
            odwiedzaneMiasta = new List<Miasto>();
            //losowanie miast do przebycia
            //bool ok = false;
            int temp;
           // Random seed = new Random();
            for (int i = 0; i < listaMiast.Count; i++)
            {

                //ok = false;
                //while (!ok)
                
                    temp = losujLiczbe(pomocniczaLista.Count, generator);
                    /*if (numeryMiast.Contains(temp) == true)
                    {
                        ok = false;
                    }
                    else
                    {
                        numeryMiast.Add(temp);
                        odwiedzaneMiasta.Add(listaMiast[temp]);
                        ok = true;
                    }*/
                    odwiedzaneMiasta.Add(pomocniczaLista[temp]);
                    pomocniczaLista.Remove(pomocniczaLista[temp]);
                

            }

            liczTrase(odwiedzaneMiasta);
            /*Odleglosci odleglosci = new Odleglosci(odwiedzaneMiasta);
            odleglosci.ObliczOdleglosci();
            for (int j = 0; j < listaMiast.Count - 1; j++)
            {
                dlugoscTrasy = dlugoscTrasy + odleglosci.macierzOdleglosci[j, j + 1];
            }*/
        }

        public void liczTrase(List<Miasto> miasta)
        {
            Odleglosci odleglosci = new Odleglosci(odwiedzaneMiasta);
            dlugoscTrasy = 0;
            odleglosci.ObliczOdleglosci();
            for (int j = 0; j < listaMiast.Count - 1; j++)
            {
                dlugoscTrasy = dlugoscTrasy + odleglosci.macierzOdleglosci[j, j + 1];
            }
        }

        public int losujLiczbe(int max, Random generator)
        {
            return generator.Next(0, max);
        }
    }
}
