using System;

namespace BasicCoreProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*****WELL COME TO BASICCOREPROBLEMS*****");
            Console.WriteLine("Please Select The Below Given option::" + "\n" + "1.FlipCoin" + "\n" + "2.LeapYear" + "\n" + "3.PowerOfTwo" + "\n" + "4.HarmonicNumber"+"\n"+ "5.QuoteintAndReminder "+"\n"+ "6.SwapTwoNumbers"+"\n"+"7.EvenAndOddNumber");
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
                        case 5:
                            Console.WriteLine("*****WELL COME TO QuoteintAndReminderProblem*****");
                            QuoteintAndReminder check = new QuoteintAndReminder();
                            check.Quotient();
                            Console.WriteLine("******Thank YOU*******");
                            break;
                        case 6:
                            Console.WriteLine("*****WELL COME TO SwapTwoNumberProblem*****");
                            SwapTwoNumbers.Swap();
                            Console.WriteLine("******Thank YOU*******");
                            break;
                        case 7:
                            Console.WriteLine("*****WELL COME TO OddAndEvenProblem*****");
                            EvenOddNumber.Number();
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
