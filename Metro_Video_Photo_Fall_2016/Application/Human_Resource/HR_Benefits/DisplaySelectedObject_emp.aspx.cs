using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Metro_Video_Photo_Fall_2016.Database;
using Metro_Video_Photo_Fall_2016.App_code;
using System.Data;


namespace Metro_Video_Photo_Fall_2016.Application.Human_Resource.HR_benefits
{
    public partial class DisplaySelectedObject_emp : System.Web.UI.Page
    {
     

             protected void Page_Load(object sender, EventArgs e)
        {
            Error.Visible = false;

            string tableName = (string)(Session["tabName"]);
            string docType = (string)(Session["docType"]);
            string docNum = (string)(Session["docNum"]);

            txtTabName.Text = tableName;
            txtDocType.Text = docType;
            txtDocNum.Text = docNum;

        }
        protected void GetDocument_Click(object sender, EventArgs e)
        {

            Error.Visible = false;
            GridView1.DataSource = null;
            GridView1.DataBind();
            try
            {
                txtQuery.Text = "select * from " + txtTabName.Text + " where docNum = " + Convert.ToInt32(txtDocNum.Text) + "And docType = " + Convert.ToInt32(txtDocType.Text);
                List<string> _selDocStr = DataBaseUtility.GetList("select * from " + txtTabName.Text + " where docNum = " + Convert.ToInt32(txtDocNum.Text) + "And docType = " + Convert.ToInt32(txtDocType.Text));

                string[] selDocStr = _selDocStr[1].Split(',');
                txtExtRef.Text = selDocStr[2];
                txtIntRef.Text = selDocStr[3];
                txtProcessNum.Text = selDocStr[4];
                txtStatus.Text = selDocStr[5];
                txtDocStartDate.Text = selDocStr[6];
                txtDocStatusDate.Text = selDocStr[7];
                txtQuotedAmt.Text = selDocStr[8];
                txtActualAmt.Text = selDocStr[9];
                txtComment.Text = selDocStr[10];
                /*code starts here*/
                try
                {

                    DB_Operations db = new DB_Operations();
                    DataTable ds = db.SelectQry("select * from " + txtTabName.Text + "_Details" + " where docNum = " + Convert.ToInt32(txtDocNum.Text) + "And docType = " + Convert.ToInt32(txtDocType.Text));

                    //con.Open();
                    //cmd = new OleDbCommand("select * from " + txtTabName.Text + "_Details" + " where docNum = " + Convert.ToInt32(txtDocNum.Text) + "And docType = " + Convert.ToInt32(txtDocType.Text), con);
                    //dr = cmd.ExecuteReader();
                    GridView1.DataSource = ds;
                    GridView1.DataBind();

                    //Attribute to show the Plus Minus Button.
                    GridView1.HeaderRow.Cells[0].Attributes["data-class"] = "expand";

                    int column_Num = GridView1.Rows[0].Cells.Count;

                    if (column_Num >= 3)
                    {
                        for (int i = 2; i <= column_Num - 1; i++)
                        {
                            //Attribute to hide column in Phone.
                            GridView1.HeaderRow.Cells[i].Attributes["data-hide"] = "phone,tablet";
                        }
                    }

                    //Adds THEAD and TBODY to GridView.
                    GridView1.HeaderRow.TableSection = TableRowSection.TableHeader;
                    // con.Close();
                }
                catch (Exception ex)
                {
                    //Debug.WriteLine("********************************************************************");
                    //Debug.WriteLine("Exception Caught: {0}", ex.Message);
                    //Debug.WriteLine("Exception Caught: {0}", ex.StackTrace);
                    //Debug.WriteLine("********************************************************************");
                }
            }
            catch (Exception ex)
            {
                Error.Visible = true;

            }
        }
        protected void ChangeDocument_Click(object sender, EventArgs e)
        {
            Session["tabName"] = txtTabName.Text;
            Session["docNum"] = txtDocNum.Text;
            Session["docType"] = txtDocType.Text;

            Response.Redirect("ChangeInfraDocument.aspx");
        }
        protected void Reset_Click(object sender, EventArgs e)
        {
            txtExtRef.Text = null;
            txtIntRef.Text = null;
            txtProcessNum.Text = null;
            txtStatus.Text = null;
            txtDocStartDate.Text = null;
            txtDocStatusDate.Text = null;
            txtQuotedAmt.Text = null;
            txtActualAmt.Text = null;
            txtComment.Text = null;
        }

    
    }
}