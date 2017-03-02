using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Metro_Video_Photo_Fall_2016.App_code;
using Metro_Video_Photo_Fall_2016.Database;

namespace Metro_Video_Photo_Fall_2016.Application.Accounting.AccountsReports
{
    public partial class AccountReports_Main : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            BalanceSheet();


            IncomeReport();

            TrialBalance();

            InteralTrialBalance();
            
        }

        private void InteralTrialBalance()
        {
            InternalTrialBalanceAsset();
            InternalTrialBalanceRevenue();
        }

        private void InternalTrialBalanceRevenue()
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
            dt.Columns.Add("Debits");
            dt.Columns.Add("Credits");

            string queryAccounts = "Select DocNum from AccountBalances where Type > 30";
            string queryAmount = "Select ActualValue from AccountBalances where Type > 30";
            string queryDebit = "Select Debit from AccountBalances where Type > 30";

            db.SelectQry(queryAccounts);
            amountAll = db.SelectQry(queryAmount);
            debits = db.SelectQry(queryDebit);
            accounts = db.SelectQry(queryAccounts);

            foreach (DataRow r in accounts.Rows)
            {
                account.Add(r["DocNum"].ToString());
            }

            foreach (DataRow r in amountAll.Rows)
            {
                amount.Add(r["ActualValue"].ToString());
            }
            foreach (DataRow r in debits.Rows)
            {
                debit.Add(r["Debit"].ToString());
            }

            for (int i = 0; i < amount.Count; i++)
            {
                amount[i] = (Convert.ToInt32(amount[i]) * Convert.ToInt32(debit[i])).ToString();
            }

            for (int i = 0; i < amount.Count; i++)
            {
                if (Convert.ToInt32(amount[i]) < 0)
                {
                    int money = -1 * Convert.ToInt32((amount[i]));
                    dt.Rows.Add(account[i], "", money.ToString());
                    revenueDebit += money;
                }
                else if (Convert.ToInt32(amount[i]) >= 0)
                {
                    dt.Rows.Add(account[i], amount[i], "");
                    revenueCredit = Convert.ToInt32(amount[i]);
                }
            }






            GridView8.DataSource = dt;
            GridView8.DataBind();
        }

        private void InternalTrialBalanceAsset()
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
            dt.Columns.Add("Debits");
            dt.Columns.Add("Credits");

            string queryAccounts = "Select DocNum from AccountBalances where Type <= 30";
            string queryAmount = "Select ActualValue from AccountBalances where Type <= 30";
            string queryDebit = "Select Debit from AccountBalances where Type <= 30";

            db.SelectQry(queryAccounts);
            amountAll = db.SelectQry(queryAmount);
            debits = db.SelectQry(queryDebit);
            accounts = db.SelectQry(queryAccounts);

            foreach (DataRow r in accounts.Rows)
            {
                account.Add(r["DocNum"].ToString());
            }

            foreach (DataRow r in amountAll.Rows)
            {
                amount.Add(r["ActualValue"].ToString());
            }
            foreach (DataRow r in debits.Rows)
            {
                debit.Add(r["Debit"].ToString());
            }

            for (int i = 0; i < amount.Count; i++)
            {
                amount[i] = (Convert.ToInt32(amount[i]) * Convert.ToInt32(debit[i])).ToString();
            }

            for (int i = 0; i < amount.Count; i++)
            {
                if (Convert.ToInt32(amount[i]) < 0)
                {
                    int money = -1 * Convert.ToInt32((amount[i]));
                    dt.Rows.Add(account[i], "", money.ToString());
                    assetDebit += money;
                }
                else if (Convert.ToInt32(amount[i]) >= 0)
                {
                    dt.Rows.Add(account[i], amount[i], "");
                    assetCredit = Convert.ToInt32(amount[i]);
                }
            }






            GridView7.DataSource = dt;
            GridView7.DataBind();
        }

        private void TrialBalance()
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
            dt.Columns.Add("Debits");
            dt.Columns.Add("Credits");

            string queryAccounts = "Select DocNum from AccountBalances";
            string queryAmount = "Select ActualValue from AccountBalances";
            string queryDebit = "Select Debit from AccountBalances";

            db.SelectQry(queryAccounts);
            amountAll = db.SelectQry(queryAmount);
            debits = db.SelectQry(queryDebit);
            accounts = db.SelectQry(queryAccounts);

            foreach (DataRow r in accounts.Rows)
            {
                account.Add(r["DocNum"].ToString());
            }

            foreach (DataRow r in amountAll.Rows)
            {
                amount.Add(r["ActualValue"].ToString());
            }
            foreach (DataRow r in debits.Rows)
            {
                debit.Add(r["Debit"].ToString());
            }

            for (int i = 0; i < amount.Count; i++)
            {
                amount[i] = (Convert.ToInt32(amount[i]) * Convert.ToInt32(debit[i])).ToString();
            }

            for (int i = 0; i < amount.Count; i++)
            {
                if (Convert.ToInt32(amount[i]) < 0)
                {
                    int money = -1 * Convert.ToInt32((amount[i]));
                    dt.Rows.Add(account[i], "", money.ToString());
                    debitValue += money;
                }
                else if (Convert.ToInt32(amount[i]) >= 0)
                {
                    dt.Rows.Add(account[i], amount[i], "");
                    creditValue = Convert.ToInt32(amount[i]);
                }
            }






            GridView6.DataSource = dt;
            GridView6.DataBind();
        }

        private void IncomeReport()
        {
            int netValue = 0;
            DataTable dtExpense = new DataTable();
            DataTable dtRevenue = new DataTable();

            DB_Operations db = new DB_Operations();


            String queryExpense = "Select DocNum, TextValue, ActualValue from AccountBalances where Type = '50'";
            String queryRevenue = "Select DocNum, TextValue, ActualValue from AccountBalances where Type = '40'";




            dtExpense = db.SelectQry(queryExpense);
            dtRevenue = db.SelectQry(queryRevenue);


            GridView4.DataSource = dtRevenue;
            GridView4.DataBind();

            GridView5.DataSource = dtExpense;
            GridView5.DataBind();

            netValue = revenue - expense;
            lblNetValue.Font.Bold = true;
            lblNetIncome.Text = "$" + netValue.ToString();
            lblNetIncome.Font.Bold = true;
        }

        private void BalanceSheet()
        {
            DataTable dtAsset = new DataTable();
            DataTable dtLiability = new DataTable();
            DataTable dtOwnership = new DataTable();
            DB_Operations db = new DB_Operations();


            String queryAsset = "Select DocNum, TextValue, ActualValue from AccountBalances where Type = '10'";
            String queryLiability = "Select DocNum, TextValue, ActualValue from AccountBalances where Type = '20'";
            String queryOwnership = "Select DocNum, TextValue, ActualValue from AccountBalances where Type = '30'";



            dtAsset = db.SelectQry(queryAsset);
            dtLiability = db.SelectQry(queryLiability);
            dtOwnership = db.SelectQry(queryOwnership);

            GridView1.DataSource = dtAsset;
            GridView1.DataBind();

            GridView2.DataSource = dtLiability;
            GridView2.DataBind();

            GridView3.DataSource = dtOwnership;
            GridView3.DataBind();

            lblTotal.Text += (liability + ownership).ToString();
            lblAsset.Text += asset;
            lblTotal.Font.Bold = true;
            lblAsset.Font.Bold = true;
            lbllo.Font.Bold = true;
        }

        protected void btn_Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Application/Accounting/Default.aspx");
        }

        int asset = 0;
        int liability = 0;
        int ownership = 0;
        int revenue = 0;
        int expense = 0;
        int debitValue = 0;
        int creditValue = 0;
        int assetDebit = 0;
        int assetCredit = 0;
        int revenueDebit = 0;
        int revenueCredit = 0;
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                asset += Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "ActualValue"));
            }
            else if (e.Row.RowType == DataControlRowType.Footer)
            {
                e.Row.Cells[2].Text = "$ " + asset.ToString();
                e.Row.Cells[2].Font.Bold = true;
            }


        }

        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                liability += Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "ActualValue"));
            }
            else if (e.Row.RowType == DataControlRowType.Footer)
            {
                e.Row.Cells[2].Text = "$ " + liability.ToString();
                e.Row.Cells[2].Font.Bold = true;
            }
        }

        protected void GridView3_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ownership += Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "ActualValue"));
            }
            else if (e.Row.RowType == DataControlRowType.Footer)
            {
                e.Row.Cells[2].Text = "$ " + ownership.ToString();
                e.Row.Cells[2].Font.Bold = true;
            }
        }

        protected void GridView4_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                revenue += Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "ActualValue"));
            }
            else if (e.Row.RowType == DataControlRowType.Footer)
            {
                e.Row.Cells[2].Text = "$ " + revenue.ToString();
                e.Row.Cells[2].Font.Bold = true;
            }
        }

        protected void GridView5_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                expense += Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "ActualValue"));
            }
            else if (e.Row.RowType == DataControlRowType.Footer)
            {
                e.Row.Cells[2].Text = "$ " + expense.ToString();
                e.Row.Cells[2].Font.Bold = true;
            }
        }

        protected void GridView6_RowDataBound(object sender, GridViewRowEventArgs e)
        {
           
            
            if (e.Row.RowType == DataControlRowType.Footer)
            {
                e.Row.Cells[1].Text = "$ " + debitValue.ToString();
                e.Row.Cells[2].Text = "$ " + creditValue.ToString();
                e.Row.Cells[1].Font.Bold = true;
                e.Row.Cells[2].Font.Bold = true;
            }
        }

        protected void GridView7_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Footer)
            {
                e.Row.Cells[1].Text = "$ " + assetDebit.ToString();
                e.Row.Cells[2].Text = "$ " + assetCredit.ToString();
                e.Row.Cells[1].Font.Bold = true;
                e.Row.Cells[2].Font.Bold = true;
            }
        }

        protected void GridView8_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Footer)
            {
                e.Row.Cells[1].Text = "$ " + revenueDebit.ToString();
                e.Row.Cells[2].Text = "$ " + revenueCredit.ToString();
                e.Row.Cells[1].Font.Bold = true;
                e.Row.Cells[2].Font.Bold = true;
            }
        }

        
    }
}
