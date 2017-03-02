using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Metro_Video_Photo_Fall_2016.Database;

namespace Metro_Video_Photo_Fall_2016.Controls
{
    public partial class DisplayTable : System.Web.UI.UserControl
    {

        public String query
        {
            get;
            set;
        }

        public String tableName
        {
            get;
            set;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DB_Operations db = new DB_Operations();
                DataTable dt = db.SelectQry(query);
                grid.DataSource = dt;
                grid.DataBind();
            }
            catch (Exception ex)
            {
                
            }
        }


        public void GetDetails(object sender, EventArgs e) 
        {
            GridViewRow row = grid.SelectedRow;
            Session["tabName"]= tableName;
            Session["docNum"] = row.Cells[1].Text;
            Session["docType"] = row.Cells[2].Text;
            Response.Redirect("/DisplaySelectedListObject.aspx");

        }

    }
}