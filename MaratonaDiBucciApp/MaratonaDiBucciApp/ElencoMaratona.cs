﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaratonaDiBucciApp
{
    class ElencoMaratone
    {

        public List<Maratona> Elenco { get; set; }
        public object TxTCitta { get; private set; }

        public ElencoMaratone()
        {
            Elenco = new List<Maratona>();
        }

        public void Aggiungi(Maratona unaMaratona)
        {
            Elenco.Add(unaMaratona);
        }

        public int TrasformaTempo(string oreMinuti)
        {
            int ore = int.Parse(oreMinuti.Substring(0, 2));

            int minuti = int.Parse(oreMinuti.Substring(3, 2));

            return ore * 60 + minuti;
        }

        public void LeggiDaFile()
        {
            using (FileStream flussoDati = new FileStream("maratona.txt", FileMode.Open, FileAccess.Read))

            {

                using (StreamReader ReaderDati = new StreamReader(flussoDati))

                {

                    while (!ReaderDati.EndOfStream)

                    {

                        string riga = ReaderDati.ReadLine();

                        string[] campi = riga.Split('%');



                        Maratona unaMaratona = new Maratona();

                        unaMaratona.Nome = campi[0];

                        unaMaratona.Società = campi[1];

                        unaMaratona.TempoInMinuti = TrasformaTempo(campi[2]);

                        unaMaratona.Città = campi[3];

                        Aggiungi(unaMaratona);

                    }
                }
            }
        }
        public string VisualizzaTempo(string maratoneta, string Citta)
        {
            
                string output = "";
            foreach (var Maratona in Elenco)
                {
                if (Maratona.Nome == maratoneta && Maratona.Città == Citta)
                    {
                        output = Maratona.TempoInMinuti.ToString();
                    }
                }
                return output;
            }
        }
    }


