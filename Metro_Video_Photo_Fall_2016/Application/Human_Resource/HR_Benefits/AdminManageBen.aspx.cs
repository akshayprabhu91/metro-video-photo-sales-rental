using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Metro_Video_Photo_Fall_2016.Database;
using System.Data;

namespace Metro_Video_Photo_Fall_2016.Application.Human_Resource.HR_benefits
{
    public partial class AdminManageBen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                try
                {
                    String sql = "Select TableName from BasicQueries";
                    DB_Operations db = new DB_Operations();
                    DataTable ds = db.SelectQry(sql);

                    if (ds.Rows.Count > 0)
                    {
                        dropDownTableName.DataSource = ds;
                        dropDownTableName.DataTextField = "TableName";
                        dropDownTableName.DataValueField = "TableName";
                        dropDownTableName.DataBind();
                        dropDownTableName.Items.Insert(0, new ListItem("Benefits", "Benefits"));
                    }
                }
                catch (Exception ex) { }

                try
                {
                    String qry = "Select DocType from DocumentTypes";
                    DB_Operations db = new DB_Operations();
                    DataTable ds = db.SelectQry(qry);
                    if (ds.Rows.Count > 0)
                    {
                        dropDownDocType.DataSource = ds;
                        dropDownDocType.DataTextField = "DocType";
                        dropDownDocType.DataValueField = "DocType";
                        dropDownDocType.DataBind();
                        dropDownDocType.Items.Insert(0, new ListItem("61", "61"));
                    }

                }
                catch (Exception ex)
                {

                }

            }
        }
        protected void dropDownTableName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void DisplayResults_Click(object sender, EventArgs e)
        {
            Error.Visible = false;
            docGrid.DataSource = null;
            docGrid.DataBind();
            try
            {
                txtTableName.Text = dropDownTableName.SelectedItem.Text;
                txtQuery.Text = " select * from " + dropDownTableName.SelectedItem.Text;
                txtDocType.Text = dropDownDocType.SelectedItem.Text;
                if (dropDownDocNumber.SelectedItem.Text == "0 -  Any Num")
                    txtDocNum.Text = "0 -  Any Num";
                else
                    txtDocNum.Text = dropDownDocNumber.SelectedItem.Text;

                // con.Open();
                String qry = "";
                if (dropDownDocType.SelectedItem.Text == "0" && dropDownDocNumber.SelectedItem.Text == "0 -  Any Num")
                {
                    qry = "select * from " + dropDownTableName.SelectedItem.Text;
                    DB_Operations db = new DB_Operations();
                    DataTable ds = db.SelectQry(qry);
                    docGrid.DataSource = ds;
                    docGrid.DataBind();
                    txtQuery.Text = " select * from " + dropDownTableName.SelectedItem.Text;
                }
                else if (dropDownDocType.SelectedItem.Text == "0" && dropDownDocNumber.SelectedItem.Text != "0 -  Any Num")
                {
                    qry = "select * from " + dropDownTableName.SelectedItem.Text + " where DocNum = " + Convert.ToInt32(txtDocNum.Text);
                    DB_Operations db = new DB_Operations();
                    DataTable ds = db.SelectQry(qry);
                    docGrid.DataSource = ds;
                    docGrid.DataBind();
                    txtQuery.Text = "select * from " + dropDownTableName.SelectedItem.Text + " where DocNum = " + txtDocType.Text;
                }
                else if (dropDownDocType.SelectedItem.Text != "0" && dropDownDocNumber.SelectedItem.Text != "0 -  Any Num")
                {
                    qry = "select * from " + dropDownTableName.SelectedItem.Text + " where DocType = " + dropDownDocType.SelectedItem.Text + " And DocNum = " + Convert.ToInt32(txtDocNum.Text);
                    DB_Operations db = new DB_Operations();
                    DataTable ds = db.SelectQry(qry);
                    docGrid.DataSource = ds;
                    docGrid.DataBind();
                    txtQuery.Text = "select * from " + dropDownTableName.SelectedItem.Text + " where DocType = " + dropDownDocType.SelectedItem.Text + " And DocNum = " + txtDocType.Text;
                }
                else if (dropDownDocType.SelectedItem.Text != "0" && dropDownDocNumber.SelectedItem.Text == "0 -  Any Num")
                {
                    qry = "select * from " + dropDownTableName.SelectedItem.Text + " where DocType = " + dropDownDocType.SelectedItem.Text;
                    DB_Operations db = new DB_Operations();
                    DataTable ds = db.SelectQry(qry);
                    docGrid.DataSource = ds;
                    docGrid.DataBind();
                    txtQuery.Text = "select * from " + dropDownTableName.SelectedItem.Text + " where DocType = " + dropDownDocType.SelectedItem.Text;
                }

                //Attribute to show the Plus Minus Button.
                docGrid.HeaderRow.Cells[0].Attributes["data-class"] = "expand";

                int column_Num = docGrid.Rows[0].Cells.Count;

                if (column_Num >= 3)
                {
                    for (int i = 2; i <= column_Num - 1; i++)
                    {
                        //Attribute to hide column in Phone.
                        docGrid.HeaderRow.Cells[i].Attributes["data-hide"] = "phone,tablet";
                    }
                }

                //Adds THEAD and TBODY to GridView.
                docGrid.HeaderRow.TableSection = TableRowSection.TableHeader;

            }
            catch (Exception ex)
            {
                Error.Visible = true;
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Error.Visible = false;
            Session["tabName"] = txtTableName.Text;
            Session["docNum"] = txtNewDocNum.Text;
            Session["docType"] = txtNewDocType.Text;

            Response.Redirect("DisplaySelectedObject_admin.aspx");
        }
        protected void docGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            Error.Visible = false;
            int rowIndex = docGrid.SelectedIndex;
            string docNum = docGrid.SelectedRow.Cells[1].Text;
            string docType = docGrid.SelectedRow.Cells[2].Text;
            txtNewDocNum.Text = docNum;
            txtNewDocType.Text = docType;
        }

        public int RowIndex { get; set; }

        protected void Reset_Click(object sender, EventArgs e)
        {
            txtDocNum.Text = null;
            txtTableName.Text = null;
            txtQuery.Text = null;
            txtDocType.Text = null;
            docGrid.DataSource = null;
            docGrid.DataBind();
            Error.Visible = false;
        }
    }



}