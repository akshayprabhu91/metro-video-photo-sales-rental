using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using Metro_Video_Photo_Fall_2016.Database;
using System.Data;

namespace Metro_Video_Photo_Fall_2016.Application.Human_Resource.Hiring.Applications
{
    public partial class ApplicationsChart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            DB_Operations db = new DB_Operations();

            DataTable dt = db.SelectQry("Select * from Applications");
            string[] x = new string[dt.Rows.Count];
            int[] y = new int[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                x[i] = dt.Rows[i][0].ToString();
                y[i] = Convert.ToInt32(dt.Rows[i][9]);
            }
            Chart1.Series[0].Points.DataBindXY(x, y);
            //Chart1.Series[0].ChartType = SeriesChartType.Pie;
            Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            
            //OleDbCommand com = new OleDbCommand();
            //com.Connection = c;
            //com.CommandText = "Select * from Applications";
            //OleDbDataReader r = com.ExecuteReader();
            //    while (r.Read())
            //    {
            //        Chart1.Series["Experience"].Points.AddXY(r["DocNum"].ToString(), r["Experience"].ToString());
            //    }
            //    c.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("" + ex);
            //}
        }
    }
}