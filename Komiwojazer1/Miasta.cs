using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Komiwojazer1
{
    class Miasta
    {
        public List<Miasto> ListaMiast = new List<Miasto>();
        
        public Miasta()
        {
            ListaMiast = new List<Miasto>();
            
            TextReader tr = new StreamReader("Miasta.txt");
            string miasto;
            int x, y, a, index = 0;
            while ((miasto = tr.ReadLine()) != null)
            {
                Miasto dodawaneMiasto = new Miasto(0, 0, 0);
                index++;
                string[] str = miasto.Split(new char[] { ' ' });
                int.TryParse(str[1], out x);
                int.TryParse(str[2], out y);
                dodawaneMiasto.WspolrzedneMiasta.X = x;
                dodawaneMiasto.WspolrzedneMiasta.Y = y;
                dodawaneMiasto.Index = index;
                ListaMiast.Add(dodawaneMiasto);
            }
            tr.Close();        
        }
    }
}
