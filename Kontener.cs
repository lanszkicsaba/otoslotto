using System;
using System.Collections.Generic;
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
    }
}
