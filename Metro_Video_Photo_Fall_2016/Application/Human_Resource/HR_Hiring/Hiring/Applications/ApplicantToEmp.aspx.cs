using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Metro_Video_Photo_Fall_2016.Database;
using Metro_Video_Photo_Fall_2016.App_code;
using System.Data;
using System.Text;



namespace Metro_Video_Photo_Fall_2016.Application.Human_Resource.Hiring.Applications
{
    public partial class ApplicantToEmp : System.Web.UI.Page
    {
        List<string> appId;
        List<string> empId;
        List<string> dataStringsList = new List<string>();
        DataTable _applicantsValues;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Error.Visible = false;
                appId = (List<string>)DataBaseUtility.GetList("select DocNum from Applicant");
                DropDownList1.DataSource = appId;
                DropDownList1.DataBind();
                DropDownList1.SelectedIndex = 0;
                txtTableName.Text = "Employees";
            }

            empId = (List<string>)DataBaseUtility.GetList("select DocNum from Employees");
           
        }

        protected void Button_Validate_Click(object sender, EventArgs e)
        {
            txtQuery.Text = "Insert into Employees Values (" + TextBox_Details.Text + "')";  
           
        }

        protected void Button_Get_Click(object sender, EventArgs e)
        {
            string currentID = empId[empId.Count - 1];
            int nextEmpID = Convert.ToInt32(currentID) + 1;

            if (DropDownList1.SelectedIndex == 0)
            {
                Response.Write("Please select applicant id first");
            }
            else
            {
                string chosenApp = DropDownList1.SelectedItem.Text;
                DB_Operations db = new DB_Operations();

                _applicantsValues = db.SelectQry("select * from Applicant where DocNum = " + chosenApp);

                string fname = _applicantsValues.Rows[0][2].ToString(); ;
                string lname = _applicantsValues.Rows[0][3].ToString();
                string add = _applicantsValues.Rows[0][4].ToString();
                string add2 = _applicantsValues.Rows[0][5].ToString();
                string city = _applicantsValues.Rows[0][6].ToString();
                string state = _applicantsValues.Rows[0][7].ToString();
                string zip = _applicantsValues.Rows[0][8].ToString();
                string country = _applicantsValues.Rows[0][9].ToString();
                string phone = _applicantsValues.Rows[0][10].ToString();
                string phone2 = _applicantsValues.Rows[0][11].ToString();
                string email = _applicantsValues.Rows[0][12].ToString();
                string dep_id = txtDep.Text;
                string role = txtRole.Text;
                string ad_level = txtAdmin.Text;
                string cmt = _applicantsValues.Rows[0][16].ToString();

                ////
                txtDocNum.Text = nextEmpID.ToString();
                txtDocType.Text = "3";
                txtExtRef.Text = fname;
                txtIntRef.Text = lname;
                txtProcNum.Text = add;
                txtStatus.Text = add2;
                txtValue.Text = city;
                txtValue2.Text = state;
                txtNumValue1.Text = zip;
                txtNumValue2.Text = country;
                txtPhone1.Text = phone;
                txtPhone2.Text = phone2;
                txtEmail.Text = email;
                txtDep.Text = dep_id;
                txtRole.Text = role;
                txtAdmin.Text = ad_level;
                txtComments.Text = cmt;

                StringBuilder dataString1 = new StringBuilder();
                dataString1.Append(txtDocNum.Text + " , ");   // entity number
                dataString1.Append(txtDocType.Text + " , '");
                dataString1.Append(txtExtRef.Text + "' , '");    // first name
                dataString1.Append(txtIntRef.Text + "' , '");
                dataString1.Append(txtProcNum.Text + "' , '");
                dataString1.Append(txtStatus.Text + "' , '");
                dataString1.Append(txtValue.Text + "' , '");
                dataString1.Append(txtValue2.Text + "' , '");
                dataString1.Append(txtNumValue1.Text + "' , '");
                dataString1.Append(txtNumValue2.Text + "' , '");
                dataString1.Append(txtPhone1.Text + "' , '");
                dataString1.Append(txtPhone2.Text + "' , '");
                dataString1.Append(txtEmail.Text + "' , '");
                dataString1.Append(txtDep.Text + "' , '");
                dataString1.Append(txtRole.Text + "' , '");
                dataString1.Append(txtAdmin.Text + "' , '");
                dataString1.Append(txtComments.Text + "'");
                dataStringsList.Add(dataString1.ToString());
                //TextBox_Details.Text = dataStringsList[0];
                TextBox_Details.Text = dataString1.ToString();
                
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
                int retcode = con.InsertUpdateDeleteQry(txtQuery.Text);
               // int retcode2 = con.InsertUpdateDeleteQry("Insert into Employees values ('" + myDoc + "')");
            }

            catch (Exception ex)
            {
                Error.Visible = true;

            }
        }
    }
}