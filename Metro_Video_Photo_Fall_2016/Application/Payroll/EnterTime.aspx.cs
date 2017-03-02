using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Metro_Video_Photo_Fall_2016.App_code;
using Metro_Video_Photo_Fall_2016.Database;
using System.Data;

namespace Metro_Video_Photo_Fall_2016.Application.Payroll
{
    public partial class EnterTime : System.Web.UI.Page
    {
       DataRow y;

       //int EMP_ID = Convert.ToInt32(HttpContext.Current.Session["user"]);
        DB_Operations db = new DB_Operations();
        protected void Page_Load(object sender, EventArgs e)
        {
            int EMP_ID = Convert.ToInt32(HttpContext.Current.Session["user"]);
            RetrieveDetails(EMP_ID);
           
            


        }
        public void RetrieveDetails(int EMP_ID)
        {
            
            string res = "select * from Timesheets  where Emp_ID=" + EMP_ID + " and week_id=(select max(week_id) from timesheets where Emp_ID=" + EMP_ID + ")";
            DataTable s = db.SelectQry(res);
            Label7.Text = s.Rows[0].ItemArray[0].ToString();
            Label8.Text = s.Rows[0].ItemArray[2].ToString();
            Label9.Text = DateTime.Parse(s.Rows[0].ItemArray[6].ToString()).AddDays(7).ToString();
            Label10.Text = DateTime.Parse(s.Rows[0].ItemArray[7].ToString()).AddDays(7).ToString();
            Label11.Text = (Convert.ToInt32(s.Rows[0].ItemArray[4].ToString()) + 1).ToString();
            Label12.Text = s.Rows[0].ItemArray[3].ToString();



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int EMP_ID = Convert.ToInt32(HttpContext.Current.Session["user"]);
            string res = "select * from Timesheets where Emp_ID=" + EMP_ID + " and week_id=(select max(week_id) from timesheets where Emp_ID=" + EMP_ID + ")";
            DataTable s = db.SelectQry(res);
            
           
            y = s.Rows[0];
            List<Int32> hourslist = new List<int>();            
                hourslist.Add(Convert.ToInt32(TextBox1.Text));
            hourslist.Add(Convert.ToInt32(TextBox2.Text));
            hourslist.Add(Convert.ToInt32(TextBox3.Text));
            hourslist.Add(Convert.ToInt32(TextBox4.Text));
            hourslist.Add(Convert.ToInt32(TextBox5.Text));

            Label9.Text = DateTime.Parse(s.Rows[0].ItemArray[6].ToString()).AddDays(7).ToString();
            Label10.Text = DateTime.Parse(s.Rows[0].ItemArray[7].ToString()).AddDays(7).ToString();
            Label11.Text = (Convert.ToInt32(s.Rows[0].ItemArray[4].ToString()) + 1).ToString();
            //label12.Text = y[3];
            List<String> hrs = new List<string>();
            
            int totalHours = 0;
            int docnum = 412;
            string docNumLatest = "select max(docnum) from Timesheets";
           DataTable doc = db.SelectQry(docNumLatest);
            DataRow docs = doc.Rows[0];
            docnum = Convert.ToInt32(docs[0]);
            docnum = docnum + 1;
            for (int i = 0; i < hourslist.Count; i++)
            {
                totalHours = totalHours + hourslist[i];
                string detailsQuery = "INSERT INTO timesheets_details (docnum, doctype, emp_id, day_of_week,hours_worked, numvalue1, numvalue2, comments )" +
                    "Values (" + docnum + ", 41, " + Label8.Text + "," + (i + 1) + ", " + hourslist[i] + ", 0, 0, 'Timesheet details for week day " + (i + 1) + "')";
                db.InsertUpdateDeleteQry(detailsQuery);
            }

             string start_time = DateTime.Parse(s.Rows[0].ItemArray[6].ToString()).AddDays(7).ToString() ;
                string end_time =  DateTime.Parse(s.Rows[0].ItemArray[7].ToString()).AddDays(7).ToString() ;
            string cmdString = "insert into Timesheets (DocNum,DocType, EMp_id, Max_Hours, Week_Id, Total_Hours_Worked, Start_date, End_date, Numvalue1,Numvalue2 ,Comments ) Values "
                + "(" + docnum + ", 41, " + Label8.Text + ", 40, " + Label11.Text + ", " + totalHours + " ,'" + DateTime.Parse(s.Rows[0].ItemArray[6].ToString()).AddDays(7).ToString() + "' ,'" + DateTime.Parse(s.Rows[0].ItemArray[7].ToString()).AddDays(7).ToString() + "', 0, 0 , 'Timesheet hours for week " + Label11.Text + "')";
            db.InsertUpdateDeleteQry(cmdString);
            //string retMessage = Utilities.DataBaseUtility.Execute(cmdString, value);
            CalculateGrossPay(Label11.Text, totalHours, EMP_ID, start_time, end_time);

            Label20.Text = "Successfully updated in timesheet";
           
        }


        private void CalculateGrossPay(string weeknum, int noOfHours, int EMP_ID, string start_date, string end_date)
        {
           
            var empId = EMP_ID;
            var docNum = 0;

            /*var tsquery = "SELECT * FROM timesheets where docnum=409";
            var tsvalue = Utilities.DataBaseUtility.GetList(tsquery);
            var noOfHours = tsvalue[6];*/

            var gpquery = "SELECT * FROM GrossPay where Emp_ID =" + empId + "";
            DataTable doc = db.SelectQry(gpquery);
            DataRow docs = doc.Rows[0];

            //docNum = Convert.ToInt32(docs[0]);

            /*var gpvalue = Utilities.DataBaseUtility.GetList(gpquery);
            String[] hp = gpvalue[1].Split(',');*/
            String hourlypay = docs["hourlypayrate"].ToString();

            /*String[] otp = gpvalue[1].Split(',');*/
            var overtimepay = docs["overtime_hourlyrate"].ToString();

            int grosspay = Convert.ToInt32(docs["grosspay"]);
            var overtimehours = 0;
            //  var noOfHours = 4;
            var totalRegular = 0;
            var totalovertime = 0;

            if (noOfHours <= 40)
            {
                totalRegular = noOfHours * Convert.ToInt32(hourlypay);
                grosspay = totalRegular;
            }
            else if (noOfHours > 40)
            {
                overtimehours = noOfHours - 40;
                totalRegular = 40 * Convert.ToInt32(hourlypay);
                totalovertime = overtimehours * Convert.ToInt32(overtimepay);
                grosspay = totalRegular + totalovertime;
            }
            
            String lastNumQue = "Select max(DocNum) from GrossPay";
            DataTable doc1 = db.SelectQry(lastNumQue);
            DataRow docs1 = doc1.Rows[0];
            docNum = Convert.ToInt32(docs1[0]);
            docNum = docNum + 1;

            /*docNum = Utilities.DataBaseUtility.GetLastNumber("GrossPay", 0, 0, 999);
            docNum = Convert.ToInt32(docNum);
            docNum++;*/

            //insert gross pay
            var insert_grosspay = "INSERT INTO GrossPay (DocNum, DocType, Emp_ID, HourlypayRate, Overtime_HourlyRate, TotalRegularpay, PayStartDate, " +
            " PayEndDate, TotalOvertimepay, GrossPay, Comments)" +
                "VALUES (" + docNum + ", 42, " + empId + ", " + hourlypay + ", " + overtimepay
                + ", " + totalRegular + ", '" + start_date + "', '" + end_date + "', " + totalovertime + ", " + grosspay + "," +
            " 'GrossPay of  Emp " + empId + " is Regular Pay + OverTime Pay for " + weeknum + " week')";

            db.InsertUpdateDeleteQry(insert_grosspay);
            //Utilities.DataBaseUtility.Execute(insert_grosspay, ident);
            calculateNetPay(grosspay, EMP_ID, start_date, end_date);
           
        }

        private void calculateNetPay(int grossPay, int empID, string start_date, string end_date)
        {
            var empId = empID;
            var docNum = 0;
            int NetPay = 0;

            String lastNumQue = "Select max(DocNum) from NetPay";
            DataTable doc1 = db.SelectQry(lastNumQue);
            DataRow docs1 = doc1.Rows[0];
            docNum = Convert.ToInt32(docs1[0]);
            docNum = docNum + 1;


            var bfquery = "SELECT * FROM EmployeeBenefits where EmpID = " + empId + "";
            DataTable dt = db.SelectQry(bfquery);
            int bf_amt = 0;
            int deducAmt = 0;
            if (dt.Rows.Count > 0)
            {
                string benefitPercent = ""+dt.Rows[0]["totalBenPercent"];
               
                 bf_amt = Convert.ToInt32(Convert.ToInt32(benefitPercent) * grossPay);
                bf_amt = bf_amt / 100;
            }
            var npquery = "SELECT * FROM  deductions where Emp_ID = " + empId;
            DataTable dt1 = db.SelectQry(npquery);
            if (dt1.Rows.Count > 0)
            {
                string deduction = "" + dt1.Rows[0]["deduction_amt"];

                 deducAmt = Convert.ToInt32(Convert.ToInt32(deduction));
                
            }




            NetPay = grossPay - (deducAmt + bf_amt);

            //insert net pay
            var insert_netpay = "INSERT INTO NetPay (DocNum, DocType, Emp_ID, Benefits_Amt, Deductions_Amt, Gross_Amt, PayStartDate, PayEndDate," +
            "NetPay_Amt, NumValue1, Comments)" +
            "values (" + docNum + ", 43, " + empId + ", " + bf_amt + ", " + deducAmt + ", "
                + grossPay + ", '" + start_date + "', '" + end_date + "', " + NetPay + ", 0,"
            + "'NetPay for Emp" + empId + "  is GrossPay - (Deductions_Amt + Benfits_Amt)')";

            db.InsertUpdateDeleteQry(insert_netpay);
           
        }
    }
    }
        
    
