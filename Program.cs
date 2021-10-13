using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordusedd
{
    class Program
    {
        /*static void Main(string[] args)
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
            Console.ReadLine();*/

            private static void n1()
            {
                int A = rnd.Next(1, 25);//arvuti arv
                int AA; //kasutaja arv
                int K = 1; //katsed
            do
            {
                Console.WriteLine("{0}Katse. Mis arv?",K);
                AA = int.Parse(Console.ReadLine());
                K++;
            } while (AA!=A && K!=6);
            if (AA=A)
            {
                Console.WriteLine("Palju õnne!");
            }
            else
            {
                Console.WriteLine("Proovi Veel");
            }
            int arv;
            int[] arvud = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Sisesta {0} arv:", i + 1);
                arv = int.Parse(Console.ReadLine());
                arvud[i] = arv;
            }
            Array.Sort(arvud);
            foreach (var a in arvud)
            {   
                Console.WriteLine(a);
            }
            Array.Sort(arvud);
            
            int arv4 = 0;
            Array.Reverse(arvud);
            foreach (var a in arvud)
            {
                arv4 = (arv4 + a)*10;
            }
            Console.ReadLine();
            }
        }
    }
}
