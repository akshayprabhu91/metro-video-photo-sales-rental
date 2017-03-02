using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using CrystalDecisions.CrystalReports.Engine; 

namespace Metro_Video_Photo_Fall_2016.Application.Human_Resource.Hiring.Applications
{
    public partial class ApplicationsReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Applications cryRpt = new Applications();
            
            cryRpt.Load(Server.MapPath("Applications.rpt"));
            CrystalReportViewer1.ReportSource = cryRpt;            
            
        }
    }
}