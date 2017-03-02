using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Metro_Video_Photo_Fall_2016.Database;
using Metro_Video_Photo_Fall_2016.App_code;

namespace Metro_Video_Photo_Fall_2016.Application.Accounting
{
    public partial class TrialBalance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<String> account = new List<String>();
            
            List<String> amount = new List<String>();
            List<String> debit = new List<String>();
            DB_Operations db = new DB_Operations();
            DataTable amountAll = new DataTable();
            DataTable debits = new DataTable();
            DataTable accounts = new DataTable();
            DataTable dt = new DataTable();
            dt.Columns.Add("Account");
            dt.Columns.Add("Credits");
            dt.Columns.Add("Debits");

            string queryAccounts = "Select DocNum from AccountBalances";
            string queryAmount = "Select ActualValue from AccountBalances";
            string queryDebit = "Select Debit from AccountBalances";
            db.SelectQry(queryAccounts);
            amountAll = db.SelectQry(queryAmount);
            debits = db.SelectQry(queryDebit);
            accounts = db.SelectQry(queryAccounts);

            foreach(DataRow r in accounts.Rows)
            {
                account.Add(r["DocNum"].ToString());
            }
            
            foreach(DataRow r in amountAll.Rows)
            {
                amount.Add(r["ActualValue"].ToString());
            }
            foreach (DataRow r in debits.Rows)
            {
                debit.Add(r["Debit"].ToString());
            }

            for(int i = 0; i < amount.Count; i ++)
            {
                amount[i] = (Convert.ToInt32(amount[i]) * Convert.ToInt32(debit[i])).ToString();
            }

            for(int i = 0; i < amount.Count; i ++)
            {
                if(Convert.ToInt32(amount[i]) < 0)
                {
                    int money = -1 * Convert.ToInt32((amount[i]));
                    dt.Rows.Add(account[i], "", money.ToString());
                }
                else if(Convert.ToInt32(amount[i]) >= 0)
                {
                    dt.Rows.Add(account[i], amount[i], "");
                }
            }
            
            
            
            

            
            GridView1.DataSource = dt;
            GridView1.DataBind();

            
            
            



        }
    }
}
