using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Exercises
{
    class SalesPersonDemo
    {
        public static void Run(string[] args)
        {
            RealEstateSalesPerson real = new RealEstateSalesPerson();
            Console.WriteLine(real.SayName());
            real.SalesSpeech();
            real.MakeSale(100);
            Console.WriteLine("Sold house for ${0} and earned ${1} commission!", real.TotalValueSold, real.CommissionRate);
            Console.WriteLine("\n\n-----------------------------------------------");

            GirlsScout girl = new GirlsScout();
            Console.WriteLine(girl.SayName());
            girl.SalesSpeech();
            girl.MakeSale(10);
            Console.WriteLine("Sold {0} box of cookies!", girl.BoxOfCookiesSold);
        }
    }
}
