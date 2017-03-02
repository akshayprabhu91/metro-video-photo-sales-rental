using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Metro_Video_Photo_Fall_2016.Database;
using System.Data;

namespace Metro_Video_Photo_Fall_2016
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Login(object sender, EventArgs e)
        {
            try
            {
                String username = txtUsername.Value;
                String password = txtPassword.Value;
                String error = "";
                bool isError = false;

                if (String.IsNullOrEmpty(username))
                {
                    error = "Please enter the Username";
                    isError = true;
                }
                else if (String.IsNullOrEmpty(password))
                {
                    error = "Please enter the password";
                    isError = true;
                }
                else
                {
                    if ((password.IndexOf(@"\") == 3) || (password.IndexOf(@"/") == 3))
                    {
                        string _userID = password.Substring(0, 3);
                        string _lname = password.Substring(4);
                        if (_userID == username)
                        {
                            String sqlQry = "select * from employees where DocNum=" + username + " and lastname = '" + _lname + "'";
                            DB_Operations db = new DB_Operations();
                            DataTable ds = db.SelectQry(sqlQry);
                            if (ds.Rows.Count > 0)
                            {
                                Session["user"] = ds.Rows[0]["DocNum"].ToString();
                                Response.Redirect("Home.aspx");
                            }
                            else
                            {
                                isError = true;
                                error = "Invalid Credentials";
                            }
                        }
                        else
                        {
                            error = "Invalid Credentials";
                        }

                    }
                    else
                    {
                        error = "Invalid Credentials";
                        isError = true;
                    }
                }

                if (isError)
                {
                    lblError.Text = error;
                    lblError.Style.Remove("display");
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}