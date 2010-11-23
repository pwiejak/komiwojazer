using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Komiwojazer1
{
    public class Miasto
    {
        public Point WspolrzedneMiasta; //wspolrzedne miasta
         
        public int Index;               //indeks miasta
        

        public Miasto(int x, int y, int i) //konsturktor miasta
        {
            WspolrzedneMiasta = new Point(x, y);
            Index = i;
        }

    }
}
