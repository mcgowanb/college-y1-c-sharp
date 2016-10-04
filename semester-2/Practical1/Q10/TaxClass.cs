using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    class TaxClass
    {
        private double lowThreshold, highThreshold, firstCharge, secondCharge;

        public TaxClass(string band)
        {
            switch (band)
            {
                case "m":
                    this.lowThreshold = 16000;
                    this.highThreshold = 64000;
                    this.firstCharge = 1600;
                    this.secondCharge = 8800;
                    break;
                default:
                    this.lowThreshold = 8000;
                    this.highThreshold = 32000;
                    this.firstCharge = 800;
                    this.secondCharge = 1600;
                    break;
            }
        }

       

        public double FirstCharge
        {
            get
            {
                return firstCharge;
            }

        }

        public double HighThreshold
        {
            get
            {
                return highThreshold;
            }


        }

        public double LowThreshold
        {
            get
            {
                return lowThreshold;
            }


        }

        public double SecondCharge
        {
            get
            {
                return secondCharge;
            }


        }
    }
}
