using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExam
{
    class PreferredCustomer : Customer
    {
        private double totalpurchase;
        private double discountlevel;

        public double TotalPurchase
        {
            set { this.totalpurchase = value; }
            get { return this.totalpurchase; }

        }

        public double DiscountLevel
        {
            get

            {
                if (this.TotalPurchase >= 500 && this.TotalPurchase < 1000)
                {
                    return 1;
                }
                else if (this.TotalPurchase >= 1000 && this.TotalPurchase < 1500)
                {
                    return 2;
                }
                else if (this.TotalPurchase >= 1500 && this.TotalPurchase < 2000)
                {
                    return 5;
                }
                else if (this.TotalPurchase >= 2000)
                {
                    return 7;
                }

                else
                    return 0;

            }
        }

    }
}
