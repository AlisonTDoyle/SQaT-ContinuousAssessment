using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SQaT_CA.Classes
{
    public class DiscountService
    {
        private double _discount = 1;

        public DiscountService(double discount) 
        {
            _discount = discount;
        }

        public double GetDiscount()
        {
            return _discount;
        }
    }
}