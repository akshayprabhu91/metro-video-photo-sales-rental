using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Metro_Video_Photo_Fall_2016.Database;
using System.Data;

namespace Metro_Video_Photo_Fall_2016
{
    /// <summary>
    /// Page Load for Site.Master , for redirection to logi page if Session["user"] is null
    /// Log
    /// Created - Harsh Patel - 9-11-2016
    /// Updated - Harsh Patel - 11-11-2016 (code to avoid redirection on default page)
    /// </summary>
    public partial class Site : System.Web.UI.MasterPage
    {
        public string name = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            String pageName = Path.GetFileName(Request.Url.AbsolutePath).ToLower();
            int urlLength = Request.Url.Segments.Length;

            if (Convert.ToInt32(ConfigurationManager.AppSettings["isDevelopment"]) == 0)
            {
                if (!Page.IsPostBack)
                {
                    if (Session["user"] == null && urlLength > 2)  // && pageName != "default.aspx"
                        Response.Redirect("/Default.aspx?type=login");
                    else 
                    {
                        String sql = "Select firstname from employees where DocNum=" + Session["user"];
                        DB_Operations db = new DB_Operations();
                        DataTable ds = db.SelectQry(sql);
                        if (ds.Rows.Count > 0)
                        {
                            name = ds.Rows[0]["firstname"].ToString();
                        }
                    }
                }
            }
            else 
            {
                Session["user"] = "test";
                name = "test";
            }
        }

        public void Logout(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ConfigurationManager.AppSettings["isDevelopment"]) == 0)
            {
                Session["user"] = null;
                Response.Redirect("/Default.aspx?type=login");
            }
        }
    }
}