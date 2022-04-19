using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OpeningWeekend
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<OpeningWeekend> filmek = new List<OpeningWeekend>();
            string[] sorok = File.ReadAllLines("nyitohetvege.txt");
            sorok=sorok.Skip(1).ToArray();
            foreach (string sorokLine in sorok) 
            {
                string[] sor = sorokLine.Split(';');
                OpeningWeekend nyitohetvege = new OpeningWeekend(
                    sor[0],
                    sor[1],
                    sor[2],
                    sor[3],
                    int.Parse(sor[4]), 
                    int.Parse(sor[5])
                    );
                filmek.Add(nyitohetvege);
                    }
            //3. feladat
            Console.WriteLine($"3.feladat: Filmek száma az állományban: {sorok.Count()} db");

            //4. feladatt
            long hetibevetel = 0;
            foreach (var item in filmek)
            {
                if (item.forgalmazo=="UIP")
                {
                    hetibevetel += item.bevel;
                }
            }
            Console.WriteLine($"4.feladat:UIP Duna Film forgalmazó 1. hetes bevételének összege: {hetibevetel} Ft");

            //5. feladat

            int max=0;
            int maxid = 0;
            for (int i = 0; i < filmek.Count; i++)
            {
                if (filmek[i].bevel>max)
                {
                    max= filmek[i].bevel;
                    maxid= i;
                }
            }
            Console.WriteLine($"5. feladat: Legtöbb látogató az első héten: ");
            Console.WriteLine($"\tEredeti cím: {filmek[maxid].eredetiCim}");
            Console.WriteLine($"\tMagyar cím:{filmek[maxid].magyarCim}");
            Console.WriteLine($"\tForgalmazó: {filmek[maxid].forgalmazo}");
            Console.WriteLine($"\tBevétel az első héten: {filmek[maxid].bevel} Ft");
            Console.WriteLine($"\tLátogatók: {filmek[maxid].latogato} fő");
            Console.ReadKey();

        }   
    }
}
