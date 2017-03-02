using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Metro_Video_Photo_Fall_2016.Controls
{
    public partial class Applicaiton_UserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string HomeUrl
        {
            get;
            set;
        }

        public void RedirectToHome(object sender,EventArgs e) 
        {
            Response.Redirect(HomeUrl);
        }

    }
}