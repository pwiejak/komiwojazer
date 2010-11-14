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
                index++;
                cbMiasta.Items.Add(miasto);
                string[] str = miasto.Split(new char[] { ' ' } );
                int.TryParse(str[1], out x);
                int.TryParse(str[2], out y);
                Miasto dodawaneMiasto = new Miasto(0, 0, 0);
                dodawaneMiasto.WspolrzedneMiasta.X = x;
                dodawaneMiasto.WspolrzedneMiasta.Y = y;
                dodawaneMiasto.Index = index;
                miasta.Add(dodawaneMiasto);
                Rectangle kropka = new Rectangle(x, y, 2, 2);
                rysunek.DrawRectangle(rysik, kropka);
                
            }
            tr.Close();
            Miasta m = new Miasta();
            Odleglosci polaczenia = new Odleglosci(miasta);
            polaczenia.ObliczOdleglosci();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Miasta M = new Miasta();
            //this.rysujTrase(M.ListaMiast);

            int rozmiar;
            int iloscIteracji = int.Parse(liczbaPokolen.Value.ToString());
            rozmiar = int.Parse(RozmiarPopulacji.Value.ToString());
            Populacja poczatkowaPopulacja = new Populacja(M.ListaMiast);
            poczatkowaPopulacja.generujLosowa(rozmiar);
            Populacja nowePokolenie = new Populacja(poczatkowaPopulacja.listaMiast);
            List<Osobnik> noweOsobniki = new List<Osobnik>();
            Osobnik min = new Osobnik();
            min = poczatkowaPopulacja.generowanaPopulacja[0];
            for (int i = 0; i < iloscIteracji; i++)
            {
                noweOsobniki = nowePokolenie.generujKolejnePokolenie(poczatkowaPopulacja.generowanaPopulacja);
                for (int j = 0; j < noweOsobniki.Count; j++)
                {
                    if (min.dlugoscTrasy > noweOsobniki[j].dlugoscTrasy)
                        min = noweOsobniki[j];
                }
            }

            minimum.Text = min.dlugoscTrasy.ToString();
            //wyswietlanie najkrotszej trasy test ! 

            rysujTrase(min.odwiedzaneMiasta);
            //Osobnik przykladowy = new Osobnik(M.ListaMiast);
        }


        public void rysujTrase(List<Miasto> trasa)
        {

            rysunek.Clear(Color.GhostWhite);
            for (int i = 0; i < trasa.Count; i++)
            {
                if (i < trasa.Count - 1)
                    rysunek.DrawLine(Pens.Black, trasa[i].WspolrzedneMiasta, trasa[i + 1].WspolrzedneMiasta);
                else
                    rysunek.DrawLine(Pens.Black, trasa[i].WspolrzedneMiasta, trasa[0].WspolrzedneMiasta);

            }
        }

    
        

    }
}
