using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratorXML
{
    public partial class Form2 : Form
    {
        private Wezel wezel;
        private List<Wezel> listaWezlow;
        private List<TextBox> listaTextBox;
        private string sciezkaDocelowa;
        public Form2(Wezel wezel, string sciezka)
        {
            this.wezel = wezel;
            listaWezlow = new List<Wezel>();
            listaTextBox = new List<TextBox>();
            this.sciezkaDocelowa = sciezka;
            InitializeComponent();
            tworzPola();
            this.Refresh();
            Button button = new Button();
            button.Text = "Dodaj";
            button.Size = new Size(80, 20);
            button.Location = new Point(listaTextBox[listaTextBox.Count-1].Location.X, listaTextBox[listaTextBox.Count-1].Location.Y + 30);
            button.Click += button_Click;
            this.Controls.Add(button);
            Button buttonGen = new Button();
            buttonGen.Text = "Generuj";
            buttonGen.Size = new Size(80, 20);
            buttonGen.Location = new Point(button.Location.X, button.Location.Y+100);
            buttonGen.Click += buttonGen_Click;
            this.Controls.Add(buttonGen);
        }

        private void dodajPole(int indeks,int kol, string nazwa)
        {
            Label label1 = new Label();
            label1.Name = nazwa;
            label1.Text = nazwa;
            label1.Size = new Size(80, 15);
            label1.Location = new Point(5 +kol*400,5 + (indeks - 1)*(label1.Height+10));            
            this.Controls.Add(label1);

            TextBox tb1 = new TextBox();
            tb1.Name = "tb" + nazwa;
            tb1.Text = nazwa;
            tb1.Size = new Size(250, 15);
            tb1.Location = new Point(label1.Width + 10 + kol * 400, 5 + (indeks - 1) * (label1.Height + 10));
            this.Controls.Add(tb1);
            listaTextBox.Add(tb1);
        }
        private void tworzPola()
        {
            int i = 1;
            int j = 0;
            foreach (var item in wezel.listaPol)
            {
                dodajPole(i,j, item.nazwa);
                i++;
                if (i % 20 == 0)
                { j++; i = 1; }
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            int i = 0;
            Wezel wezel2 = new Wezel();
            wezel2.naglowek = wezel.naglowek;
            wezel2.wezel = wezel.wezel;
            foreach (var item in wezel.listaPol)
            {
                Pole pole = new Pole();
                pole.nazwa = item.nazwa;
                wezel2.listaPol.Add(pole);
            }
            foreach (var item in listaTextBox)
            {
                wezel2.listaPol[i].wartosc = item.Text;
                item.Text = "";
                i++;
            }
            listaWezlow.Add(wezel2);

        }
        private void buttonGen_Click(object sender, EventArgs e)
        {
            GenerujXML gen = new GenerujXML(listaWezlow,sciezkaDocelowa);
            gen.genruj();
            listaWezlow.Clear();
        }


    }
}
