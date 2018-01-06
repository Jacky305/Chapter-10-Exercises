using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Exercises
{
    class RealEstateSalesPerson:SalesPerson
    {
        private double totalValueSold = 0;
        private double commissionRate = 0;
        public double TotalValueSold { get { return totalValueSold; } set { totalValueSold = value; } }
        public double CommissionRate { get { return commissionRate; } set { commissionRate = value; } }

        public RealEstateSalesPerson() : base("House","Seller")
        {
            this.SayName();
            
        }

        public override void SalesSpeech()
        {
            Console.WriteLine("Selling estates!");
        }
        public override void MakeSale(int housePrice)
        {
            this.TotalValueSold += housePrice;
            this.CommissionRate = totalValueSold * 0.20;
            //Console.WriteLine("{0}\t{1}", this.totalValueSold, this.commissionRate);
        }
    }
}
