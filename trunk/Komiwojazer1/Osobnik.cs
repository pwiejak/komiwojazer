using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Komiwojazer1
{
    class Osobnik
    {
        public List<Miasto> odwiedzaneMiasta; 
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
            odwiedzaneMiasta = new List<Miasto>();
            int temp;

            for (int i = 0; i < listaMiast.Count; i++)
            {
                    temp = losujLiczbe(pomocniczaLista.Count, generator);
                    odwiedzaneMiasta.Add(pomocniczaLista[temp]);
                    pomocniczaLista.Remove(pomocniczaLista[temp]);
            }

            liczTrase(odwiedzaneMiasta);
        }

        public void liczTrase(List<Miasto> miasta)  //funkcja wyliczajaca dlugosc trasy
        {
            Odleglosci odleglosci = new Odleglosci(odwiedzaneMiasta);
            dlugoscTrasy = 0;
            odleglosci.ObliczOdleglosci();
            for (int j = 0; j < listaMiast.Count - 1; j++)
            {
                dlugoscTrasy = dlugoscTrasy + odleglosci.macierzOdleglosci[j, j + 1];
            }
        }

        public int losujLiczbe(int max, Random generator) //generator liczb losowych
        {
            return generator.Next(0, max);
        }
    }
}
