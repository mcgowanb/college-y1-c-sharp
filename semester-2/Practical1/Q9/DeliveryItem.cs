using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    class DeliveryItem
    {
        private int weight;
        private string deliveryType;
        private double fee = 0;
        private const double FLAT_FEE = 2.5;

        public string DeliveryType
        {
            get
            {
                return deliveryType;
            }

            set
            {
                deliveryType = value.ToLower();
            }
        }

        public int Weight
        {
            get
            {
                return weight;

            }
            set
            {
                weight = value;
            }
        }

        public double cost()
        {
            fee = basicRateCalculator();
            if (weight > 2000)
                fee += (2000 * .025);

            else
                fee += (weight * .025);


            if (weight > 2000 && weight <= 5000)
                fee += ((weight - 2000)) * .03;

            if (weight > 5000)
                fee += ((weight - 5000) * .05);

            return fee;
        }


        private double basicRateCalculator()
        {
            double value = FLAT_FEE;
            switch (deliveryType)
            {
                case "x":
                    value += 1.5;
                    break;
                case "sx":
                    value += 2.5;
                    break;
                case "ssx":
                    value += 3.5;
                    break;
                default:
                    break;
            }
            return value;
        }





    }
}
