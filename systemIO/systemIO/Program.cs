using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string putanja = @"C:\Users\Korisnik\Documents";
            if(Directory.Exists(putanja))
            {
                Console.WriteLine("Datoteke: ");
                foreach (string datoteka in Directory.GetFiles(putanja))
                {
                    Console.WriteLine(datoteka);
                }
            }
            string mapa1 = putanja + @"\test";
            if (Directory.Exists(mapa1))
            {
                Console.WriteLine("\nMapa izbrisana.");
                Directory.Delete(mapa1);
            }
            else
            {
                Console.WriteLine("\nMapa kreirana.");
                Directory.CreateDirectory(mapa1);
            }
           if (Directory.Exists(putanja))
            {
                Console.WriteLine("\nPodmape:");
                foreach (string datoteka in Directory.GetDirectories(putanja))
                {
                    Console.WriteLine(datoteka);
                }
            }
            Console.ReadKey();

        }
    }
}
