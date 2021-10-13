using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordusedd
{
    class Abivahend
    {
        public static void Main(string[] arg)
        {
            Console.WriteLine(alamprogramm.Korruta(3, 6));
            double arv1 = 5;
            double arv2 = 6;

            Double result = alamprogramm.Eval(arv1.ToString() + "+" + arv2.ToString());
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
