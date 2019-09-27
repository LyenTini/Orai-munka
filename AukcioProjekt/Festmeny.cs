using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AukcioProjekt
{
    public class Festmeny
    {
        private string cim;
        private string festo;
        private string stilus;
        private int licitekSzama = 0;
        private int legmagasabbLicit = 0;
        private DateTime legutolsoLicitIdeje=DateTime.Now;
        private bool elkelt = false;

        public Festmeny(string cim, string festo, string stilus)
        {
            this.cim = cim;
            this.festo = festo;
            this.stilus = stilus;

        }

        public int LicitekSzama { get => licitekSzama; set => licitekSzama = value; }
        public int LegmagasabbLicit { get => legmagasabbLicit; set => legmagasabbLicit = value; }
        public DateTime LegutolsoLicitIdeje { get => legutolsoLicitIdeje; set => legutolsoLicitIdeje = value; }
        public bool Elkelt { get => elkelt; set => elkelt = value; }



        public void Beolvas()
        {
            List<Festmeny> fajl = new List<Festmeny>();
            try
            {
                
                StreamReader olvas = new StreamReader("Festmeny.csv",Encoding.UTF8);
                while (!olvas.EndOfStream)
                {
                    
                    string sor = olvas.ReadLine();
                    string[] st = sor.Split(';');
                    string festo = st[0];
                    string cim = st[1];
                    string stilus = st[2];

                    
                }
                olvas.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Hiba "+e);
            }
            foreach (string s in fajl)
            {
                fajl.Add(s);
            }
        }

        public void Kiir()
        {
            if (elkelt==true)
            {
                Console.WriteLine("Elkelt.");
            }
            else if(elkelt==false)
            {
                Console.WriteLine("Nem kelt el.");
            }
            Console.WriteLine("{0}: {1} ({2})",this.festo,this.cim,this.stilus);
            Console.WriteLine("{0}$ - {1} (összesen: {2} db)",this.legmagasabbLicit,legutolsoLicitIdeje,licitekSzama);
            
        }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}

        //public static List<Festmeny> Beolvas()
        //{
        //    string[] festmeny = File.ReadAllLines("festmeny.csv");
        //    List<Festmeny> lista = List<Festmeny>();
        //    foreach (var f in festmeny)
        //    {
        //        string[] tomb = f.Split(';');
        //        Festmeny f1 = new Festmeny(tomb[0], tomb[1], tomb[2]);
        //        lista.Add(f1);
        //    }
        //    return lista;
        //}

    }
}
