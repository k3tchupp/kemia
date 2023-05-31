using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LINQ_dolgozat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Adat> lista = new List<Adat>();

            using (StreamReader sr = new StreamReader("felfedezesek.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    Adat s = new Adat(sor);
                    lista.Add(s);
                }
            }

            Console.WriteLine($"3. feladat: Elemek száma: {lista.Count}");

            int okor = lista.Where(x=>x.Ev == "Ókor").Count();
            Console.WriteLine($"4. feladat: Felfedezések száma az ókorban: {okor}");

            string betuk = Console.ReadLine();

            while (betuk.Length == 2 || betuk.Length == 1 && )
            {

            }

            Console.WriteLine("6. feladat: Keresés");
            foreach (var item in lista.Where(x => x.Vegyjel.Contains(betuk)))
            {
                Console.WriteLine($"\tAz elem vegyjele: {item.Vegyjel}");

                Console.WriteLine($"\tAz elem neve: {item.Nev}");

                Console.WriteLine($"\tRendszáma: {item.Rendszam}");

                Console.WriteLine($"\tFelfedezés éve: {item.Ev}");

                Console.WriteLine($"\tFelfedező: {item.Felfedezo}");
            }



            int legkisebb = lista.Where(x=> x.Ev.Contains)
            Console.WriteLine($"7. feladat: {} év volt a leghosszabb idő két elem felfedezése között.");
        }
    }
}
