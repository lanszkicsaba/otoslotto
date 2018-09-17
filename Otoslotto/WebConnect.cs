using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Otoslotto
{
    class Downloader
    {
        string uri = "https://bet.szerencsejatek.hu/cmsfiles/otos.csv";

        public void Downloading()
        {
            WebClient webClient = new WebClient();

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            webClient.DownloadFile(uri, "otos.csv");
        }
    }
    class FileCommand
    {
        public void FileDel(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
        }
    }
    class WebConnect
    {
        private Kontener kontener = new Kontener();
        private string path = "otos.csv";

        public Kontener InReader()
        {
            TextFieldParser csvParser = new TextFieldParser(path);
            csvParser.CommentTokens = new string[] { "#" };
            csvParser.SetDelimiters(new string[] { ";" });
            csvParser.HasFieldsEnclosedInQuotes = true;

            // Skip the row with the column names
            // csvParser.ReadLine();

            while (!csvParser.EndOfData)
            {
                // Read current line fields, pointer moves to the next line.
                string[] fields = csvParser.ReadFields();

                string One = fields[11];
                string Two = fields[12];
                string Three = fields[13];
                string Four = fields[14];
                string Five = fields[15];
                kontener.Hozzad(new Szamok(int.Parse(One), int.Parse(Two), int.Parse(Three), int.Parse(Four), int.Parse(Five)));
            }
            csvParser.Close();
            return kontener;
        }
    }
}
