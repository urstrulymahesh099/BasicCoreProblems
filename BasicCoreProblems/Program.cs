using System;

namespace BasicCoreProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*****WELL COME TO BASICCOREPROBLEMS*****" );
            Console.WriteLine("Please Select The Below Given option::"+ "\n" + "1.FlipCoin"+"\n"+"2.LeapYear");
            int option = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            while (flag)
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("*****WELL COME TO FlipCoinProblem*****");
                        FlipCoin filpcoin = new FlipCoin();
                        filpcoin.CheckHeadTail();
                        break;
                    case 2:
                        Console.WriteLine("*****WELL COME TO LeapYearProblem*****");
                        LeapYear.Year();
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
