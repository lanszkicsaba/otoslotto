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
                return elso;
            }
            private set
            {
                if (value < 1 || value > 90)
                {
                    MessageBox.Show("Hibás adatbevitel!");
                }
                else
                {
                    elso = value;
                }
            }
        }

        private int masodik;

        public int Masodik
        {
            get
            {
                return masodik;
            }
            private set
            {
                if (value < 1 || value > 90)
                {
                    MessageBox.Show("Hibás adatbevitel!");
                }
                else
                {
                    masodik = value;
                }
            }
        }

        private int harmadik;

        public int Harmadik
        {
            get
            {
                return harmadik;
            }
            private set
            {
                if (value < 1 || value > 90)
                {
                    MessageBox.Show("Hibás adatbevitel!");
                }
                else
                {
                    harmadik = value;
                }
            }
        }

        private int negyedik;

        public int Negyedik
        {
            get
            {
                return negyedik;
            }
            private set
            {
                if (value < 1 || value > 90)
                {
                    MessageBox.Show("Hibás adatbevitel!");
                }
                else
                {
                    negyedik = value;
                }
            }
        }

        private int otodik;

        public int Otodik
        {
            get
            {
                return otodik;
            }
            private set
            {
                if (value < 1 || value > 90)
                {
                    MessageBox.Show("Hibás adatbevitel!");
                }
                else
                {
                    otodik = value;
                }
            }
        }

        public Szamok(int elso, int masodik, int harmadik, int negyedik, int otodik)
        {
            this.Elso = elso;
            this.Masodik = masodik;
            this.Harmadik = harmadik;
            this.Negyedik = negyedik;
            this.Otodik = otodik;
        }

    }
}
