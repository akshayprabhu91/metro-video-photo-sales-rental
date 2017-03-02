using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Metro_Video_Photo_Fall_2016.Application.Payroll
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void grossPay_Click(object sender, EventArgs e)
        {
            Response.Redirect("GrossPay.aspx?option=grosspay");
        }

        protected void netPay_Click(object sender, EventArgs e)
        {
            Response.Redirect("GrossPay.aspx?option=netpay");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Application/Payroll/Timesheet.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("GrossPay.aspx?option=payslip");
        }

        protected void dashboard_Click(object sender, EventArgs e)
        {
            Response.Redirect("dashboard.aspx");
        }
        
        /*protected void paycheck_Click(object sender, EventArgs e)
        {
            Response.Redirect("GrossPay.aspx?option=payslip");
        }

        protected void timesheet_Click(object sender, EventArgs e)
        {
            //Response.Redirect("GrossPay.aspx?option=payslip");
        }*/
    }
}