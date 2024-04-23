using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SQaT_CA.Classes
{
    public class InsuranceService
    {
        // Properties
        private readonly DiscountService discountService;

        // Constructors
        public InsuranceService(DiscountService ds)
        {
            discountService = ds;
        }

        // Methods
        public double CalcPremium(int age, string location)
        {
            // Variables
            double premium = 0;

            // Check location
            if (location == "rural")
            {
                // Check age
                if ((age >= 18) && (age <= 30))
                {
                    premium = 5.0;
                }
                else if (age >= 31)
                {
                    premium = 3.50;
                }
            }
            else if (location == "urban")
            {
                // Check age
                if ((age >= 18) && (age <= 35))
                {
                    premium = 6.0;
                }
                else if (age >= 36)
                {
                    premium = 5.0;

                }
            }

            // Apply discount if applicable
            double discount = discountService.GetDiscount();
            if (age >= 50)
            {
                premium = premium * discount;
            }

            return premium;
        }
    }

}