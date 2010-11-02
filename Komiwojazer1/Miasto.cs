using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Komiwojazer1
{
    class Miasto
    {
        public Point WspolrzedneMiasta;
        public int Index;
        

        public Miasto(int x, int y, int i)
        {
            WspolrzedneMiasta = new Point(x, y);
            Index = i;
        }
    }
}
