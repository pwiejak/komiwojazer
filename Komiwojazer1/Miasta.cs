﻿using System;
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
            Miasto dodawaneMiasto = new Miasto(0, 0, 0);
            TextReader tr = new StreamReader("Miasta.txt");
            string miasto;
            int x, y, a, index = 0;
            while ((miasto = tr.ReadLine()) != null)
            {
                index++;
                a = miasto.IndexOf(" ");
                int.TryParse(miasto.Substring(a + 1, 3), out x);
                int.TryParse(miasto.Substring(a + 5), out y);
                dodawaneMiasto.WspolrzedneMiasta.X = x;
                dodawaneMiasto.WspolrzedneMiasta.Y = y;
                dodawaneMiasto.Index = index;
                ListaMiast.Add(dodawaneMiasto);
            }
            tr.Close();        
        }
    }
}
