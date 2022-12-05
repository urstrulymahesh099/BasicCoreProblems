using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class LeapYear
    {
        public static void Year()
        {
            Console.WriteLine("Enter the Required Year");
            int year=Convert.ToInt32(Console.ReadLine());
            if (( year % 4 == 0 ||  year % 400 == 0) && year % 100 != 0)
            {
                Console.WriteLine("The Mentioned Year Is  "+   year   +"  Leap Year");
            }
            else
                Console.WriteLine("Year is not a Leap Year");
                Console.WriteLine("Yess You Found required year.\nThank YOU");
        }
 
    }
}
