using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratorXML
{
    public partial class Form3 : Form
    {
        private Wezel wezel;
        private List<Wezel> listaWezlow;
        private string sciezkaDocelowa;
        public Form3(Wezel wezel, string sciezka)
        {
            this.wezel = wezel;
            listaWezlow = new List<Wezel>();
            this.sciezkaDocelowa = sciezka;
            InitializeComponent();
        }

        private void wczytajZPliku()
        {
            string[] linie = File.ReadAllLines(tbSciezka.Text);
            foreach (var item in linie)
            {
                string[] linia = item.Split(tbSeparator.Text.ToCharArray());
                Wezel wezel2 = new Wezel();
                wezel2.naglowek = wezel.naglowek;
                wezel2.wezel = wezel.wezel;
                foreach (var item2 in wezel.listaPol)
                {
                    Pole pole = new Pole();
                    pole.nazwa = item2.nazwa;
                    wezel2.listaPol.Add(pole);
                }
                try
                {
                    int i = 0;
                    foreach (var item3 in wezel2.listaPol)
                    {
                        item3.wartosc = linia[i];
                        i++;
                    }
                    i = 0;
                }
                catch
                { }
                listaWezlow.Add(wezel2);
            }
        }

        private void buttonGenruj_Click(object sender, EventArgs e)
        {
            try
            {
                wczytajZPliku();
                GenerujXML gen = new GenerujXML(listaWezlow,sciezkaDocelowa);
                gen.genruj();
                listaWezlow.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }
    }
}
