using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GeneratorXML
{
    public class GenerujXML
    {
        private List<Wezel> listaWezlow;
        private string sciezka = "output.xml";
        public GenerujXML(List<Wezel> lW)
        {
            this.listaWezlow = lW;
        }
        public GenerujXML(List<Wezel> lW, string sciezka)
        {
            this.listaWezlow = lW;
            this.sciezka = sciezka;
        }
        public void genruj()
        {
            XmlTextWriter Writer = new XmlTextWriter(sciezka, null);
            Writer.Formatting = Formatting.Indented;
            Writer.WriteStartDocument();
            Writer.WriteStartElement(listaWezlow[0].naglowek);
            foreach (var item in listaWezlow)
            {
                Writer.WriteStartElement(item.wezel);
                foreach (var atrybut in item.listaPol)
                {
                    Writer.WriteStartElement(atrybut.nazwa);
                    Writer.WriteString(atrybut.wartosc);
                    Writer.WriteEndElement();
                }
                
                Writer.WriteEndElement();
            }
            Writer.WriteEndElement();
            Writer.WriteEndDocument();

            Writer.Close();
        }

    }
}
