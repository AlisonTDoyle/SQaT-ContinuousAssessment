using SQaT_CA.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQaT_CA
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Variables
            bool validAge = false;
            bool validLocation = false;
            string enteredAge = tbxAge.Text;
            string location = "";
            int age = 0;

            // Make sure user has entered a valid age
            if (int.TryParse(enteredAge, out int test))
            {
                validAge = true;
                age = test;
            }

            // Make sure a user has selected a location
            if (rbRural.Checked && !rbUrban.Checked)
            {
                validLocation = true;
                location = "rural";
            }
            else if ((!rbRural.Checked) && (rbUrban.Checked))
            {
                validLocation = true;
                location = "urban";
            }
        
            if (validAge && validLocation)
            {
                InsuranceService insuranceService = new InsuranceService();
                double premium = insuranceService.CalcPremium(age, location);

                result.Text = premium.ToString();
            }
        }
    }
}