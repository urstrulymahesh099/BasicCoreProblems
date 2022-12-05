using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class PowerOfTwo
    {
        public void Power()
        {
            Console.WriteLine("Enter the Given base Number");
            int number=Convert.ToInt32(Console.ReadLine());

            for (int power = 0; power <= 32; power++)
            {
                    {
                        double powerOfTwo = Math.Pow(number, power);
                        Console.WriteLine("Power Of  " + powerOfTwo);
                    }
                
            }
        }
    }
}
