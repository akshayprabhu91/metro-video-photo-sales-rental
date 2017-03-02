using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Metro_Video_Photo_Fall_2016.Controls;

namespace Metro_Video_Photo_Fall_2016.Application.Payroll
{
    public partial class TimeSheet : System.Web.UI.Page
    {
        public string user {get; set;}
        
        protected void Page_Load(object sender, EventArgs e)
        {
            this.DisplayTable.query = "select * from timesheets where emp_id="+HttpContext.Current.Session["user"];
        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Application/Payroll/EnterTime.aspx");
        }
    }
}