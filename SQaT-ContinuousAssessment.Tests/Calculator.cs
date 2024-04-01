using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQaT_ContinuousAssessment.Tests
{
    //Sorry Sam, but the Github project didn't have the exact code needed to make the test cases
    //So I had to copy it into a new project - Tristan :P
    
    //Sorry Alison, But the CSHTML would not covert back into the Exact C#
    //even when put thru Ghirdra. Decomplication is not like unbaking a cake
    //its reverse-engineering the cake's recipe - Tristan :(.
    public class Calculator
    {
        public class AgeBasedDiscountService
        {
            // Method to get the discount based on users age.
            public double GetDiscount(int age)
            {
                // Check if their age is negative.
                if (age < 0)
                {
                    // Throw an error if the user's age is negative.
                    throw new ArgumentException("Your age cannot be negative silly.");
                }

                // If they are aged 50 or more, give a 10% discount, otherwise no discount. :(
                return age >= 50 ? 0.9 : 1.0;
            }
        }

        // Calculating the insurance premiums.
        public class InsuranceService
        {
            // Variable used for the discount service.
            public AgeBasedDiscountService _discountService;

            // My constructor to start the discount service.
            public InsuranceService(AgeBasedDiscountService discountService)
            {
                _discountService = discountService;
            }

            // Calculating the insurance premium.
            public double CalcPremium(int age, string location)
            {
                // Variable to store the premium.
                double premium = 0.0;

                // If the user lives in a rural area...
                if (location == "rural")
                {
                    // Users aged 18 - 30 have a premium of �5. Anyone older has �3.50.
                    if (age >= 18 && age <= 30)
                        premium = 5.0;
                    else if (age >= 31)
                        premium = 3.50;
                }

                // If the user lives in an urban area...
                else if (location == "urban")
                {
                    // Users aged 18 - 35 have a premium of �6. Anyone older has �5.
                    if (age >= 18 && age <= 35)
                        premium = 6.0;
                    else if (age >= 36)
                        premium = 5.0;
                }

                // If the premium is still 0 (under 18's), return.
                else
                {
                    return premium;
                }

                // Apply the discount for people aged 50 or more.
                double discount = _discountService.GetDiscount(age);
                premium *= discount;

                // Return the premium.
                return premium;
            }
        }
    }
}
