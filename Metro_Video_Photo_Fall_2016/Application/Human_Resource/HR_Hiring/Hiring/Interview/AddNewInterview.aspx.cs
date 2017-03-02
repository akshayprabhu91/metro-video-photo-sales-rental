using Metro_Video_Photo_Fall_2016.App_code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using Metro_Video_Photo_Fall_2016.Database;
using System.Data.SqlClient;


namespace Metro_Video_Photo_Fall_2016.Application.Human_Resource.Hiring.Interview
{
    public partial class AddNewInterview : System.Web.UI.Page
    {
        DataTable _detailTable;
        List<String> _detailList;
        List<String> id;
        protected void Page_Load(object sender, EventArgs e)
        {
            Error.Visible = false;
            txtTableName.Text = "Interview";
            txtDocType.Text = "64";
           
            //ResetCommand();
            id = (List<string>)DataBaseUtility.GetList("select DocNum from Interview");
            string currentID = id[id.Count - 1];
            int nextID = Convert.ToInt32(currentID) + 1;
            txtDocNum.Text = nextID.ToString();
        }
        protected void Button_Validate_Click(object sender, EventArgs e)
        {

            try
            {

                Error.Visible = false;
                _detailList = (List<string>)Session["detailList"];

                StringBuilder dataString1 = new StringBuilder();
                dataString1.Append(txtDocNum.Text.Trim() + ", ");
                dataString1.Append(txtDocType.Text.Trim() + ", ");
                dataString1.Append(txtExtRef.Text.Trim() + ", ");
                dataString1.Append(txtIntRef.Text.Trim() + ", ");
                dataString1.Append(txtStatus.Text.Trim() + ", ");
                dataString1.Append(txtProcNum.Text.Trim() + ", ");
                dataString1.Append("'" + txtValue.Text.Trim() + "', ");
                dataString1.Append("'" + txtValue2.Text.Trim() + "', ");
                dataString1.Append(txtNumValue1.Text.Trim() + ", ");
                dataString1.Append(txtNumValue2.Text.Trim() + ", ");
                dataString1.Append("'" + txtComments.Text.Trim() + "'");

                TextBox_Details.Text = dataString1.ToString();
                _detailTable = (DataTable)Session["Interview"];
                int lastrow = _detailTable.Rows.Count - 1;
                //txtQuery.Text = "Insert into Interview values ('" ;
                for (int i = 0; i <= lastrow; i++)
                {
                    TextBox_Details.Text += "\r\n";
                    for (int j = 0; j < 7; j++)
                        TextBox_Details.Text += _detailTable.Rows[i][j].ToString().Trim() + ", ";
                    TextBox_Details.Text += "'" + _detailTable.Rows[i][7].ToString().Trim() + "'";
                    //txtQuery.Text += "'" + _detailTable.Rows[i][7].ToString().Trim() + "'";
                }
                //txtQuery.Text += "')"; 
            }
            catch (Exception ex)
            {
                // Error.Visible = true;
                //Debug.WriteLine("********************************************************************");
                //Debug.WriteLine("Exception Caught: {0}", ex.Message);
                //Debug.WriteLine("Exception Caught: {0}", ex.StackTrace);
                //Debug.WriteLine("********************************************************************");
            }
        }

        protected void Button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Error.Visible = false;
                GenDoc myDoc = new GenDoc();
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('function disabled; Are you sure that you want to save ? ')", true);

                string _tableName = txtTableName.Text;
                List<string> myData = new List<string>();
                string[] records = TextBox_Details.Text.Split('\r');
                for (int i = 0; i < records.Length; i++)
                    myData.Add(records[i].ToString().Trim());

                DB_Operations con = new DB_Operations();
                
                myDoc = new GenDoc(myData);
                //SqlCommand objcmd = new SqlCommand("Insert into Interview values ('" + myData + "')");
                int retcode = con.InsertUpdateDeleteQry("Insert into Interview values ('" + myData + "')");
                int retcode2 = con.InsertUpdateDeleteQry("Insert into Interview values ('" + myDoc + "')");
            }

            catch (Exception ex)
            {
                Error.Visible = true;

            }
        }

        protected void Button_Reset_Click(object sender, EventArgs e)
        {

        }

    }
}