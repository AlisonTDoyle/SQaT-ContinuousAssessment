using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQaT_CA
{
    public partial class Contact : Page
    {
        protected decimal _premium = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            string premiumUrlValue = Request.QueryString["premium"];
            _premium = Convert.ToDecimal(premiumUrlValue);
        }
    }
}