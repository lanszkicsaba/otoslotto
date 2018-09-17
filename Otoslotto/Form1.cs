using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otoslotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Kontener contener;

        private void Form1_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile("lohere.png");
            Image image2 = Image.FromFile("18karika.png");
            pictureBox1.Image = image;
            pictureBox2.Image = image2;

            try
            {
                WebConnect reader = new WebConnect();
                Downloader downloader = new Downloader();
                FileCommand commander = new FileCommand();

                downloader.Downloading();

                contener = reader.InReader();

                commander.FileDel("otos.csv");

                contener.SavetoTxt();
            }
            catch (WebException)
            {
                contener = new Kontener();

                StreamReader file = new StreamReader("szamok.txt");

                while (!file.EndOfStream)
                {
                    int elso = int.Parse(file.ReadLine());
                    int masodik = int.Parse(file.ReadLine());
                    int harmadik = int.Parse(file.ReadLine());
                    int negyedik = int.Parse(file.ReadLine());
                    int otodik = int.Parse(file.ReadLine());

                    contener.Hozzad(new Szamok(elso, masodik, harmadik, negyedik, otodik));
                }
            }
        }

        private void sorsolas_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            elsotextBox.Clear();
            masodiktextBox.Clear();
            harmadiktextBox.Clear();
            negyediktextBox.Clear();
            otodiktextBox.Clear();

            for (int i = 0; i < 1; i++)
            {
                int elso = contener.szam[rnd.Next(0, contener.szam.Count)].Elso;
                int masodik = contener.szam[rnd.Next(0, contener.szam.Count)].Masodik;
                int harmadik = contener.szam[rnd.Next(0, contener.szam.Count)].Harmadik;
                int negyedik = contener.szam[rnd.Next(0, contener.szam.Count)].Negyedik;
                int otodik = contener.szam[rnd.Next(0, contener.szam.Count)].Otodik;

                if (elso == masodik || elso == harmadik || elso == negyedik || elso == otodik || masodik == harmadik || masodik == negyedik || masodik == otodik || harmadik == negyedik || harmadik == otodik || negyedik == otodik)
                {
                    i--;
                    continue;
                }

                int[] szamok = new int[5] { elso, masodik, harmadik, negyedik, otodik };

                //rendezes
                int seged = 0;

                for (int s = 0; s < szamok.Length - 1; s++)
                {
                    for (int a = s + 1; a < szamok.Length; a++)
                    {
                        if (szamok[s] > szamok[a])
                        {
                            seged = szamok[s];
                            szamok[s] = szamok[a];
                            szamok[a] = seged;
                        }
                    }
                }

                //kiiratas
                elsotextBox.AppendText(szamok[0].ToString());
                masodiktextBox.AppendText(szamok[1].ToString());
                harmadiktextBox.AppendText(szamok[2].ToString());
                negyediktextBox.AppendText(szamok[3].ToString());
                otodiktextBox.AppendText(szamok[4].ToString());
            }
        }

        private void torles_Click(object sender, EventArgs e)
        {
            elsotextBox.Clear();
            masodiktextBox.Clear();
            harmadiktextBox.Clear();
            negyediktextBox.Clear();
            otodiktextBox.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.lanszkicsaba.ucoz.com");
        }
    }
}
