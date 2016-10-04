using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApp
{
    class Quote
    {
        private double phoneCost;
        private int age;
        private string location;
        private int previousClaim;

        public Quote(double phoneCost, int age, string location, int previousClaim)
        {
            PhoneCost = phoneCost;
            Age = age;
            Location = location;
            PreviousClaim = previousClaim;
        }

        public double PhoneCost {
            get { return phoneCost; }
            set { phoneCost = value; }
        }
        public int Age { get; set; }
        public string Location { get; set; }
        public int PreviousClaim { get; set; }



    }
}
