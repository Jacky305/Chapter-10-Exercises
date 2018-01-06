using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Exercises
{
    class GirlsScout:SalesPerson
    {
        private int boxOfCookiesSold;
        public int BoxOfCookiesSold { get { return boxOfCookiesSold; } set { boxOfCookiesSold = value; } }

        public GirlsScout() : base("Girls","Scout")
        {
            this.SayName();
        }
        public override void SalesSpeech()
        {
            Console.WriteLine("Selling cookies!");
        }
        public override void MakeSale(int boxOfCookies)
        {
            boxOfCookiesSold += boxOfCookies;
        }
    }
}
