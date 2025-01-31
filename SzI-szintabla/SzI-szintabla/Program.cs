using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KD_Fajlkezeles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Fájlbeolvasás - kep.txt
            KD - 2024.11.29.
            */

            string fejlec = "Fájlbeolvasás - kep.txt";
            Console.WriteLine(fejlec);
            for (int i = 0; i < fejlec.Length; i++) Console.Write('-');
            Console.WriteLine();

            string sor;
            string[] reszek;
            StreamReader be = new StreamReader("kep.txt");
            
            

            /*
            foreach (string s in reszek) 
                Console.Write(s);
            */

            sor = be.ReadLine();

            while (sor != null)
            {
                reszek = sor.Split(' ');

            Console.WriteLine($"piros: {reszek[0]}, zöld: {reszek[1]}, kék: {reszek[2]}");
            sor = be.ReadLine();
            }

            be.Close();

            Console.WriteLine("Kilépéshez nyomja meg az ENTER billentyűt!");
            Console.ReadLine();

        }
    }
}