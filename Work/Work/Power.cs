using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    public class PowerOf2
    {
        public void PowerMethod()
        {
            Console.WriteLine("Enter the Number");
            int N = Convert.ToInt32(Console.ReadLine());

            while (N > 0 && N < 31)
            {
                Console.WriteLine("Enter the Correct Number");
                N = Convert.ToInt32(Console.ReadLine());
            }
            if (N > 0 && N < 31)
            {
                for (int i = 0; i < N; i++)
                    Console.WriteLine(2 + " ^ " + i + " = " + Math.Pow(2, i));
            }

        }
    }
}
