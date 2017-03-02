using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Metro_Video_Photo_Fall_2016.App_code;
using System.Text;
using System.Data;

namespace Metro_Video_Photo_Fall_2016
{
    public partial class ChangeInfraDocument : DataBaseUtility
    {
        DataTable _detailTable;
        List<String> _detailList;
        protected void Page_Load(object sender, EventArgs e)
        {
            Error.Visible = false;
            
            string tableName = (string)(Session["TabName"]);
            string docType = (string)(Session["docType"]);
            string docNum = (string)(Session["docNum"]);

            txtTableName.Text = tableName;
            txtDocType.Text = docType;
            txtDocNum.Text = docNum;
            ResetCommand();
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
                // datastrings.Add(dataString1.ToString());
                TextBox_Details.Text = dataString1.ToString();
                _detailTable = (DataTable)Session["detailTable"];
                int lastrow = _detailTable.Rows.Count - 1;
                for (int i = 0; i <= lastrow; i++)
                {
                    TextBox_Details.Text += "\r\n";
                    for (int j = 0; j < 7; j++)
                        TextBox_Details.Text += _detailTable.Rows[i][j].ToString().Trim() + ", ";
                    TextBox_Details.Text += "'" + _detailTable.Rows[i][7].ToString().Trim() + "'";
                }
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


        protected void button_GetDoc_Click(object sender, EventArgs e)
        {
            // txtQuery.Text = "select * from " + txtTableName.Text + " where docNum = " + Convert.ToInt32(txtDocNum.Text) + "And docType = " + Convert.ToInt32(txtDocType.Text);
            try
            {
                Error.Visible = false;
                Console.WriteLine(txtQuery.Text);
                List<string> _selDocStr = DataBaseUtility.GetList(txtQuery.Text);

                string[] selDocStr = _selDocStr[1].Split(',');
                txtExtRef.Text = selDocStr[2];
                txtIntRef.Text = selDocStr[3];
                txtProcNum.Text = selDocStr[4];
                txtStatus.Text = selDocStr[5];
                txtValue.Text = selDocStr[6];
                txtValue2.Text = selDocStr[7];
                txtNumValue1.Text = selDocStr[8];
                txtNumValue2.Text = selDocStr[9];
                txtComments.Text = selDocStr[10];
                string cmdStr2 = String.Format("select * from {0}_Details where docNum = {1} and doctype = {2}",
                          txtTableName.Text.Trim(), txtDocNum.Text, txtDocType.Text);

                _detailTable = DataBaseUtility.GetTable(cmdStr2);
                changeDataGrid.DataSource = _detailTable;
                changeDataGrid.DataBind();

                //Attribute to show the Plus Minus Button.
                changeDataGrid.HeaderRow.Cells[0].Attributes["data-class"] = "expand";

                int column_Num = changeDataGrid.Rows[0].Cells.Count;

                if (column_Num >= 3)
                {
                    for (int i = 2; i <= column_Num - 1; i++)
                    {
                        //Attribute to hide column in Phone.
                        changeDataGrid.HeaderRow.Cells[i].Attributes["data-hide"] = "phone,tablet";
                    }
                }

                //Adds THEAD and TBODY to GridView.
                changeDataGrid.HeaderRow.TableSection = TableRowSection.TableHeader;

                //  _detailList = DataBaseUtility.GetList(cmdStr2);
                Session["detailTable"] = _detailTable;

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
        protected void Button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                Error.Visible = false;
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('function disabled; Deleting the Document will erase all the existing data permenanatly. Are you sure you want to DELETE the Document ? ')", true);
                DataBaseUtility.DeleteDocument(base.ident, txtTableName.Text, txtDocNum.Text, txtDocType.Text);

            }
            catch (Exception ex)
            {
                Error.Visible = true;
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
                // if (response == "no") return; else 
                //  return; 
                string _tableName = txtTableName.Text;
                List<string> myData = new List<string>();
                string[] records = TextBox_Details.Text.Split('\r');
                for (int i = 0; i < records.Length; i++)
                    myData.Add(records[i].ToString().Trim());
                // int myDataCount = myData.Count;
                myDoc = new GenDoc(myData);
                int retcode = myDoc.SaveDocument(base.ident, _tableName, txtDocNum.Text, txtDocType.Text, myData);
                // string retMessage = myDoc.SaveDocument(base.ident, textBox_TableName.Text, textBox_DocumentID.Text, textBox_DocType.Text, myData);
            }

            catch (Exception ex)
            {
                Error.Visible = true;
                //Debug.WriteLine("********************************************************************");
                //Debug.WriteLine("Exception Caught: {0}", ex.Message);
                //Debug.WriteLine("Exception Caught: {0}", ex.StackTrace);
                //Debug.WriteLine("********************************************************************");
            }
        }
        protected virtual void ResetCommand()
        {
            try
            {
                Error.Visible = false;
                //txtTableName.Text =  (string)(Session["TableName"]);
                //txtDocType.Text = (string)(Session["docType"]);
                //txtDocNum.Text = (string)(Session["docNum"]);
                Session["tableName"] = txtTableName.Text;
                Session["docNum"] = txtDocNum.Text;
                Session["docType"] = txtDocType.Text;
                string part1 = "select * from " + txtTableName.Text;
                string part2 = "";
                string part3 = "";
                if ((txtDocType.Text != "") && (txtDocType.Text != "0"))
                    part2 = " where docType = " + txtDocType.Text;
                if ((txtDocNum.Text != "") && (txtDocNum.Text != "0"))
                    if ((txtDocType.Text != "") && (txtDocType.Text != "0"))
                        part3 = " and DocNum =  " + txtDocNum.Text; // comboBox_DocNum.SelectedItem.ToString();
                    else part3 = " where DocNum =  " + txtDocNum.Text; //comboBox_DocNum.SelectedItem.ToString();

                txtQuery.Text = part1 + part2 + part3;
                Session["query"] = txtQuery.Text;
            }
            catch (Exception ex)
            {
                Error.Visible = true;
                //Debug.WriteLine("********************************************************************");
                //Debug.WriteLine("Exception Caught: {0}", ex.Message);
                //Debug.WriteLine("Exception Caught: {0}", ex.StackTrace);
                //Debug.WriteLine("********************************************************************");
            }
        }

        //protected virtual void ResetCommand()
        //{
        //    string part1 = "select * from " + txtTableName.Text;
        //    string part2 = "";
        //    string part3 = "";
        //    if ((txtDocType.Text != "") && (txtDocType.Text != "0"))
        //        part2 = " where docType = " + txtDocType.Text;
        //    if ((txtDocNum.Text != "") && (txtDocNum.Text != "0"))
        //        if ((txtDocType.Text != "") && (txtDocType.Text != "0"))
        //            part3 = " and DocNum =  " + txtDocNum.Text; // comboBox_DocNum.SelectedItem.ToString();
        //        else part3 = " where DocNum =  " + txtDocNum.Text; //comboBox_DocNum.SelectedItem.ToString();

        //    txtQuery.Text = part1 + part2 + part3;
        //}

        protected void Button_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                Error.Visible = false;
                //txtTableName.Text = Session["tableName"] as String ;
                //txtDocNum.Text = Session["docNum"] as String ;
                //txtDocType.Text = Session["docType"] as String ;
                string part1 = "select * from " + txtTableName.Text;
                string part2 = "";
                string part3 = "";
                if ((txtDocType.Text != "") && (txtDocType.Text != "0"))
                    part2 = " where docType = " + txtDocType.Text;
                if ((txtDocNum.Text != "") && (txtDocNum.Text != "0"))
                {
                    if ((txtDocType.Text != "") && (txtDocType.Text != "0"))
                        part3 = " and DocNum =  " + txtDocNum.Text; // comboBox_DocNum.SelectedItem.ToString();
                    else part3 = " where DocNum =  " + txtDocNum.Text; //comboBox_DocNum.SelectedItem.ToString();
                }
                txtQuery.Text = part1 + part2 + part3;
                Session["tableName"] = txtTableName.Text;
                Session["docNum"] = txtDocNum.Text;
                Session["docType"] = txtDocType.Text;
                Session["query"] = txtQuery.Text;
            }
            catch (Exception ex)
            {
                Error.Visible = true;
                //Debug.WriteLine("********************************************************************");
                //Debug.WriteLine("Exception Caught: {0}", ex.Message);
                //Debug.WriteLine("Exception Caught: {0}", ex.StackTrace);
                //Debug.WriteLine("********************************************************************");
            }

        }

        protected void txtDocNum_TextChanged(object sender, EventArgs e)
        {
            //    Session["docNum"] = txtDocNum.Text;
            //    txtDocNum.Text = (String) Session["docNum"];

        }
        protected void txtTableName_TextChanged(object sender, EventArgs e)
        {
            //    Session["TableName"] = txtTableName.Text;
            //    txtTableName.Text = (String)Session["TableName"];

        }
        protected void txtDocType_TextChanged(object sender, EventArgs e)
        {
            //Session["docType"] = txtDocType.Text;
            //txtDocType.Text = (String)Session["docType"];

        }
    }
}