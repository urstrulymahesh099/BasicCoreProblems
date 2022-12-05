using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class HarmonicNumber
    {
        public void Harmonic()
        {
            Console.WriteLine("Enter the number");
            double num = Convert.ToInt32(Console.ReadLine());
            for (double i = 1; i <= num; i++)
            {
                num += (double)(1 / i);
                Console.WriteLine(" Series is " + num);
            }
        }
    }
}