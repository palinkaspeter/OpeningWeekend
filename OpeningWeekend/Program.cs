using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OpeningWeekend
{
    internal class Program
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
            Console.WriteLine($"3.feladat: {sorok.Count()}");
            Console.ReadKey();
        }   
    }
}
