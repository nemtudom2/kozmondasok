using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kozmondasok
{
    internal class Program
    {
        static List<string> egyesites(List<string> elso, List<string> masodik)
        {
            new StreamWriter("egyesitett.txt").Write(string.Join("\n", elso) +'\n'+ string.Join("\n", masodik));
            return elso.Concat(masodik).ToList();
        }
        static List<string> kiir(List<string> egyesitett)
        {
            egyesitett.Sort();
            foreach (string line in egyesitett)
                Console.WriteLine(line);
            return egyesitett;
        }
        static void nem
        static void Main(string[] args)
        {
            var elso = (from x in new StreamReader("szoveg1.txt").ReadToEnd().Split('\n') select x.Trim()).ToList();
            elso.RemoveAt(elso.Count - 1);
            var masodik = (from x in new StreamReader("szoveg2.txt").ReadToEnd().Split('\n') select x.Trim()).ToList();
            masodik.RemoveAt(masodik.Count - 1);
            Console.WriteLine($"az elso file {elso.Count()} a masodik {masodik.Count()} sort tartalmaz");
            kiir(egyesites(elso, masodik));

            Console.ReadLine();
        }
    }
}
