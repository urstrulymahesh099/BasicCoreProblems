using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class FlipCoin
    {
        double percentageOfHead = 0, percentageOfTail = 0;
        double headCount=0,tailCount=0;

        public void CheckHeadTail()
        {
            Console.WriteLine("Enter the number of times want to Filp the Coins:");
            int noOfCountTimes=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<noOfCountTimes;i++)
            {
               Random randobj = new Random();
               randobj.Next();
                {
                    if(randobj.Next(1,2) <0.5)
                    {
                        tailCount++;
                        Console.WriteLine("TailCount :"+ tailCount);
                    }
                    else
                        headCount++;
                        Console.WriteLine("HeadCount :" + headCount);

                    Console.WriteLine("---->>>>>PERCENTAGE OF HEAD AND TAIL COUNT<<<<<-----");
                    percentageOfHead = headCount / noOfCountTimes * 100;
                    percentageOfTail = tailCount / noOfCountTimes * 100;
                    Console.WriteLine("Percentage of Head Count :" + percentageOfHead + "%");
                    Console.WriteLine("Percentage of Tail Count :" + percentageOfTail + "%");
                    Console.WriteLine("******Thank YOU*******");

                }               
            }

        }
    }
}
