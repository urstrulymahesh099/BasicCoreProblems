﻿using System;

namespace BasicCoreProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*****WELL COME TO BASICCOREPROBLEMS*****");
            Console.WriteLine("Please Select The Below Given option::" + "\n" + "1.FlipCoin" + "\n" + "2.LeapYear" + "\n" + "3.PowerOfTwo" + "\n" + "4.HarmonicNumber");
            while (true)
            {
                int option = Convert.ToInt32(Console.ReadLine());
                {
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("*****WELL COME TO FlipCoinProblem*****");
                            FlipCoin filpcoin = new FlipCoin();
                            filpcoin.CheckHeadTail();
                            Console.WriteLine("******Thank YOU*******");
                            break;
                        case 2:
                            Console.WriteLine("*****WELL COME TO LeapYearProblem*****");
                            LeapYear.Year();
                            Console.WriteLine("******Thank YOU*******");
                            break;
                        case 3:
                            Console.WriteLine("*****WELL COME TO PowerOfTwoProblem*****");
                            PowerOfTwo power = new PowerOfTwo();
                            power.Power();
                            Console.WriteLine("******Thank YOU*******");
                            break;
                        case 4:
                            Console.WriteLine("*****WELL COME TO HarmonicNumberProblrm*****");
                            HarmonicNumber number = new HarmonicNumber();
                            number.Harmonic();
                            Console.WriteLine("******Thank YOU*******");
                            break;
                        default:
                            Console.WriteLine("Please Enter Valid option");
                            Console.WriteLine("******Thank YOU*******");
                            break;


                    }

                }




            }
        }
    }
}
