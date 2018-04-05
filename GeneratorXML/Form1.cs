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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonPWW_Click(object sender, EventArgs e)
        {
            Wezel wezel = new Wezel(tbNaglowek.Text.ToLower(), tbWezel.Text.ToLower());
            var lista = rtbPola.Text.Split();
            foreach(var item in lista)
            {
                Pole pole = new Pole();
                pole.nazwa = item;
                wezel.listaPol.Add(pole);
            }
            Form2 f2 = new Form2(wezel,tbSciezka.Text);
            f2.Show();
        }

        private void buttonWWZP_Click(object sender, EventArgs e)
        {
            Wezel wezel = new Wezel(tbNaglowek.Text.ToLower(), tbWezel.Text.ToLower());
            var lista = rtbPola.Text.Split();
            foreach (var item in lista)
            {
                Pole pole = new Pole();
                pole.nazwa = item;
                wezel.listaPol.Add(pole);
            }
            Form3 f3 = new Form3(wezel, tbSciezka.Text);
            f3.Show();
        }
    }
}
