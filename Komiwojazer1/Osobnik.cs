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

        public void generujLosowego()
        {
            List<int> numeryMiast = new List<int>();
            odwiedzaneMiasta = new List<Miasto>();
            //losowanie miast do przebycia
            bool ok = false;
            int temp;
            for (int i = 0; i < listaMiast.Count; i++)
            {

                ok = false;
                while (!ok)
                {
                    temp = losujLiczbe(listaMiast.Count);
                    if (numeryMiast.Contains(temp) == true)
                    {
                        ok = false;
                    }
                    else
                    {
                        numeryMiast.Add(temp);
                        odwiedzaneMiasta.Add(listaMiast[temp]);
                        ok = true;
                    }
                }

            }

            Odleglosci odleglosci = new Odleglosci(odwiedzaneMiasta);
            odleglosci.ObliczOdleglosci();
            for (int j = 0; j < listaMiast.Count - 1; j++)
            {
                dlugoscTrasy = dlugoscTrasy + odleglosci.macierzOdleglosci[j, j + 1];
            }
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
