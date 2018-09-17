using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otoslotto
{
    class Kontener
    {
        public List<Szamok> szam = new List<Szamok>();
        public void Hozzad(Szamok s)
        {
            szam.Add(s);
        }

        public Szamok this[int i]
        {
            get
            {
                return szam[i];
            }
        }

        public void SavetoTxt()
        {
            TextWriter tw = new StreamWriter("szamok.txt");

            foreach (var item in szam)
            {
                tw.WriteLine(string.Format(item.Elso.ToString()));
                tw.WriteLine(string.Format(item.Masodik.ToString()));
                tw.WriteLine(string.Format(item.Harmadik.ToString()));
                tw.WriteLine(string.Format(item.Negyedik.ToString()));
                tw.WriteLine(string.Format(item.Otodik.ToString()));
            }
            tw.Close();
        }
    }
}
