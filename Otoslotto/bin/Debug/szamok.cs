using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otoslotto
{
    class Szamok
    {
        private int elso;

        public int Elso
        {
            get
            {
                if (elso < 1 || elso > 90)
                {
                    MessageBox.Show("Hibás adatbevitel!");
                }
                return elso;
            }
        }

        private int masodik;

        public int Masodik
        {
            get
            {
                if (elso < 1 || elso > 90)
                {
                    MessageBox.Show("Hibás adatbevitel!");
                }
                return masodik;
            }
        }

        private int harmadik;

        public int Harmadik
        {
            get
            {
                if (elso < 1 || elso > 90)
                {
                    MessageBox.Show("Hibás adatbevitel!");
                }
                return harmadik;
            }
        }

        private int negyedik;

        public int Negyedik
        {
            get
            {
                if (elso < 1 || elso > 90)
                {
                    MessageBox.Show("Hibás adatbevitel!");
                }
                return negyedik;
            }
        }

        private int otodik;

        public int Otodik
        {
            get
            {
                if (elso < 1 || elso > 90)
                {
                    MessageBox.Show("Hibás adatbevitel!");
                }
                return otodik;
            }
        }

        public Szamok(int elso, int masodik, int harmadik, int negyedik, int otodik)
        {
            this.elso = elso;
            this.masodik = masodik;
            this.harmadik = harmadik;
            this.negyedik = negyedik;
            this.otodik = negyedik;
        }

    }
}
