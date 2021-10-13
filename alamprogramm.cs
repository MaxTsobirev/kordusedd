using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordusedd
{
    class alamprogramm
    {
        public static int Korruta(int arv1, int arv2)
        {
            return arv1 * arv2;
        }

        public static Double Eval(String expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, string.Empty));

        }

        static void Main(string[] args)
        {
            int a = 2;
            int b = 5;
            Console.WriteLine("{0} * {1} = {2}", a, b, Korruta(a, b));
            Double result = alamprogramm.Eval("5+6");
            Console.WriteLine(Korruta(3, 6));
            Console.ReadLine();
        }
    }

}
