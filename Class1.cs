﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordusedd
{
    class Class1
    {
        public static void Main(string[] argumendid)
        {
            int ridadearv = 10, veergudearv = 10;
            if (argumendid.Length ==2)
            {
                ridadearv = int.Parse(argumendid[0]);
                veergudearv = int.Parse(argumendid[1]);
            }
            for (int rida = 1; rida < ridadearv; rida++)
            {
                for (int veerg = 1; veerg < veergudearv; veerg++)
                {
                    Console.WriteLine("{0,5}", rida * veerg);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
