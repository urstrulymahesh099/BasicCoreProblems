using System;

namespace BasicCoreProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*****WELL COME TO BASICCOREPROBLEMS*****" );
            Console.WriteLine("Please Select The Below Given option::"+ "\n" + "1.FlipCoin");
            int option = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            while (flag)
            {
                switch (option)
                {
                    case 1:
                        FlipCoin filpcoin = new FlipCoin();
                        filpcoin.CheckHeadTail();
                        break;
                    default:
                        flag = false;
                        Console.WriteLine("Please Enter Valid option");
                        break;
                }
                
            }
               



            }
        }
    }
