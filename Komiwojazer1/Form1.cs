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
    public partial class Form1 : Form
    {
        Graphics rysunek;
        Pen rysik = new Pen(Color.Black, 2);

        public Form1()
        {
            InitializeComponent();
            rysunek = this.pictureBox1.CreateGraphics();  
        }

        private void btWczytajMiasta_Click(object sender, EventArgs e)
        {
            List<Miasto> miasta = new List<Miasto>();
            
            TextReader tr = new StreamReader("Miasta.txt");
            string miasto;
            int x, y, a, index = 0;
            while ((miasto = tr.ReadLine()) != null)
            {
                Miasto dodawaneMiasto = new Miasto(0, 0, 0);
                index++;
                cbMiasta.Items.Add(miasto);
                a = miasto.IndexOf(" ");
                int.TryParse(miasto.Substring(a+1, 3), out x);
                int.TryParse(miasto.Substring(a + 5), out y);
                dodawaneMiasto.WspolrzedneMiasta.X = x;
                dodawaneMiasto.WspolrzedneMiasta.Y = y;
                dodawaneMiasto.Index = index;
                miasta.Add(dodawaneMiasto);
                Rectangle kropka = new Rectangle(x, y, 2, 2);
                rysunek.DrawRectangle(rysik, kropka);
                
            }
            tr.Close();
            Miasta m = new Miasta();
        }

        

    }
}
