using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorXML
{
    public class Wezel
    {
        public string naglowek;
        public string wezel;
        public List<Pole> listaPol;
        public Wezel()
        {
            naglowek = "";
            wezel = "";
            listaPol = new List<Pole>();
        }
        public Wezel(string nag, string wez)
        {
            naglowek = nag;
            wezel = wez;
            listaPol = new List<Pole>();
        }
    }
}
