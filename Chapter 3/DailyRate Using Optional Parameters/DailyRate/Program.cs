#region Using directives

using System;


#endregion

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        public void run()
        {
            double fee = calculateFee(theDailyRate: 375);
            Console.WriteLine("Fee is {0} ", fee);
        }

        private double calculateFee(double theDailyRate = 500.0, int noOfDays = 5)
        {
            Console.WriteLine("calculateFee using two optional parameters");
            return theDailyRate * noOfDays;
        }

        private double calculateFee(double dailyRate = 500.0)
        {
            Console.WriteLine("calculateFee using one optional parameter");
            int defaultNOfDays = 1;
            return dailyRate * defaultNOfDays;
        }

        private double calculateFee()
        {
            Console.WriteLine("calculateFee using hardcoded values");
            double defaultDailyRate = 400.0;
            int defaultNOfDays = 1;
            return defaultDailyRate * defaultNOfDays;
        }



    }
}
