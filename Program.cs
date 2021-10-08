using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordusedd
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int N = rnd.Next(2, 6);
            int M = rnd.Next(7, 14);
            int[] mass = new int[M - N];
            for ( int i = N; i < M+1; i++)
            {
                Console.Write(i - N+1);
                Console.ReadLine();
                mass[i-N]
                Console.Write("{0}", i * i)
            }
            foreach (var m in mass)
            {
                Console.WriteLine(m);
            }

            string[] nimed = new string[4] { "a", "b", "c", "d" };
            nimed[2] = "Anna";
            int nr = 0;
            while (nr <= 3)
            {
                Console.WriteLine("Tere, {0} õpilane", nimed[nr]);
                nr = nr + 1;
            }
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine("Tere, {0} õpilane", nimed[i]);
            }
            foreach (var nimi in nimed)
            {
                Console.WriteLine("Tere, {0} õpilane", nimi);
            }
            nr = 0;
            do
            {
                Console.WriteLine("Tere, {0} õpilane", nimed[nr]);
                nr++;
            } while (nr != nimed.Length);
            Console.ReadLine();


        }
    }
}
