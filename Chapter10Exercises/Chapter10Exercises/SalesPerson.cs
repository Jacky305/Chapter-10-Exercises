using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Exercises
{
    abstract class SalesPerson: ISellable
    {
        private string firstName;
        private string lastName;
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }

        public SalesPerson(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }
        virtual public string SayName()
        {
            return FirstName + " " + LastName;
        }

        public abstract void SalesSpeech();
        public abstract void MakeSale(int value);
    }
}
