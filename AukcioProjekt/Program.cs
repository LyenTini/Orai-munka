using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AukcioProjekt;

namespace AukcioProjekt
{
    class Program
    {
        static List<Festmeny> lista2 = new List<Festmeny>();
        public void Hozzaad()
        {
            
            foreach (var f in lista)
            {
                Festmeny f1 = new Festmeny("Fék", "Ákos", "Expresszionizmus");
                Festmeny f2 = new Festmeny("Menny", "Miklós", "Barokk");
                lista.Add(f1);
                lista.Add(f2);
            }
            Console.WriteLine(lista);

        }
        static List<Festmeny> lista = new List<Festmeny>();
        static void Main(string[] args)
        {
            Festmeny f1 = new Festmeny("Kém", "András", "Futurizmus");
            Festmeny f2 = new Festmeny("Ég", "Ágnes", "Futurizmus");
            f1.Kiir();
            Console.WriteLine();
            f2.Kiir();
            




            Console.ReadLine();
        }
    }
}
