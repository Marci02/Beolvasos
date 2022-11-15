using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Beolvasos
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader be = new StreamReader("adatok.txt");

            //for (int i = 0; i < 10; i++)
            //{
            //    string[] filmek = be.ReadLine().Split(';');

            //    string film = filmek[0];
            //    int evszam = Convert.ToInt32(filmek[1]);

            //    Console.WriteLine($"A(z) {i + 1}. legjobb film: {film} ({evszam})");
            //}

            int i = 0;

            while (!be.EndOfStream)
            {
                string[] filmek = be.ReadLine().Split(';');

                string film = filmek[0];
                int evszam = Convert.ToInt32(filmek[1]);

                Console.WriteLine($"A(z) {i+1}. legjobb film: {film.PadLeft(30)} ({evszam})");

                i++;
            }

            be.Close();
            Console.ReadKey();
        }
    }
}
