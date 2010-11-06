using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Komiwojazer1
{
    class Odleglosci
    {
        int iloscMiast;
        List<Miasto> listaMiast;
        public int[,] macierzOdleglosci;

        public Odleglosci(List<Miasto> miasta)
        {
            macierzOdleglosci = new int[miasta.Count , miasta.Count];
            iloscMiast = miasta.Count;
            //List<Miasto> listaMiast = new List<Miasto>();
            listaMiast = miasta;
        }

        public void ObliczOdleglosci()
        {
            double odleglosc;
            for (int i = 0; i < iloscMiast; i++)
            {
                for (int j = 0; j < iloscMiast; j++)
                {
                    odleglosc = System.Math.Sqrt((double)(  ((listaMiast[j].WspolrzedneMiasta.X - listaMiast[i].WspolrzedneMiasta.X) * 
                                                    (listaMiast[j].WspolrzedneMiasta.X - listaMiast[i].WspolrzedneMiasta.X))
                                                    + ((listaMiast[j].WspolrzedneMiasta.Y - listaMiast[i].WspolrzedneMiasta.Y) * 
                                                    (listaMiast[j].WspolrzedneMiasta.Y - listaMiast[i].WspolrzedneMiasta.Y)) ) );
                    macierzOdleglosci[i,j] = (int)odleglosc;
                }
            }
        }

    }
}
