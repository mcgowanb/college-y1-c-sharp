using System;

namespace Q10
{
    class Tax
    {
        private string status;
        private const double BASIC_TAX_RATE = .1, MED_TAX_RATE = .15, HIGH_TAX_RATE = .25;
        private double taxRate, salary;

        public Tax(string status, double salary)
        {
            this.status = status;
            this.salary = salary;
            taxRate = 0;
        }

        public string calculateTax()
        {
            TaxClass tc = new TaxClass(status);

            if (salary <= tc.LowThreshold)
            {
                taxRate = salary * BASIC_TAX_RATE;
            }

            if ((salary >= tc.LowThreshold) && (salary <= tc.HighThreshold))
            {
                taxRate += (salary - tc.LowThreshold) * MED_TAX_RATE + tc.FirstCharge;
            }

            if (salary > tc.HighThreshold)
            {
                taxRate += (salary - tc.HighThreshold) * HIGH_TAX_RATE + tc.SecondCharge;
            }

            return ToString();
        }


        public override string ToString()
        {
            return String.Format("The Tax rate for this user with a salary of {0:c2} is: {1:c2}", salary, taxRate);
        }
    }
}
