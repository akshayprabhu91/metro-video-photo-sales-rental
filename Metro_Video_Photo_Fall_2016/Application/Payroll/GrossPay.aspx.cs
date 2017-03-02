using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using iTextSharp;
using Metro_Video_Photo_Fall_2016.App_code;
using iTextSharp.text;
using System.IO;
using Metro_Video_Photo_Fall_2016.Database;

namespace Metro_Video_Photo_Fall_2016.Application.Payroll
{
    public partial class GrossPay1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string option = Request.QueryString["option"];
                if (option.Equals("grosspay"))
                {
                    actionFor.Text = "Calculate Gross Pay";
                    
                }

                else if (option.Equals("netpay"))
                {
                    actionFor.Text = "Calculate Net Pay";
                   
                }

                else if (option.Equals("payslip"))
                {
                    actionFor.Text = "Download Pay Check";
                    
                    
                }
                DB_Operations dbObj = new DB_Operations();

                DataTable dataTable = dbObj.SelectQry("select start_date,end_date from Timesheets where emp_id=" + HttpContext.Current.Session["user"]);

                List<string> timePeriods = new List<string>();

                timePeriods.Add("Select the Period");
                if (dataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        timePeriods.Add(dataTable.Rows[i]["start_date"] + " To " + dataTable.Rows[i]["end_date"]);
                    }

                }

                payperiod.DataSource = timePeriods;

                payperiod.DataBind();


                string roleQuery = "SELECT * FROM employees where docnum=" + HttpContext.Current.Session["user"];

                DataTable dataTable1 = dbObj.SelectQry(roleQuery);
                string role = "";

                if (dataTable1.Rows.Count > 0)
                {

                    role = dataTable1.Rows[0]["Role"].ToString();

                }

                //write role logic here


                //if (role.Equals("Supervisor  "))
                //{
                //    employeesAdmin.Visible = true;

                //    for (int i = 101; i < 111; i++)
                //    {
                //        employeeList.Add(i);
                //    }


                //    employeesAdmin.DataSource = employeeList;
                //}

                // actionFor.Text = "Calculate Gross Pay";
            }

        }

        protected void actionFor_Click(object sender, EventArgs e)
        {

            DB_Operations dbObj = new DB_Operations();
            string datecombination = payperiod.SelectedValue.ToString();
            datecombination = datecombination.Replace(" To ", ",");
            var arrayelement = datecombination.Split(',');

            string employeeID = "" + HttpContext.Current.Session["user"];

            // arrayelement[0] = arrayelement[0].Remove(arrayelement[0].Length - 13);




            if (actionFor.Text.Equals("Calculate Gross Pay"))
            {
                //calculate Gross Pay

                content.Text = "Following are the Gross Pay details:";
                head.Text = "Gross Pay";

                var stringvalue = "SELECT * FROM grosspay where emp_id = " + employeeID;



                //var stringvalue = "SELECT * FROM ([employees] AS [e] INNER JOIN [grosspay] AS [g] ON [e].[DocNum] = [g].[emp_id]) INNER JOIN [NETPAY] AS [N] ON [N].[emp_id]=[e].[DocNum] where [e].docNum=" + employeeID + " and [g].PayStartDate like '%" + arrayelement[0] + "%' and [N].PayStartDate like '%" + arrayelement[0] + "%'";

                DataTable dt = dbObj.SelectQry(stringvalue);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string date = "" + dt.Rows[i]["PayStartDate"];
                        if (date.Equals(arrayelement[0]))
                        {
                            label1.Visible = true;
                            label1.Text = "Employee ID : ";
                            label1txt.Visible = true;
                            label1txt.Text = dt.Rows[i]["emp_id"].ToString();

                            label2.Visible = true;
                            label2txt.Visible = true;
                            label2.Text = "Hourly Pay Rate";
                            label2txt.Text = dt.Rows[i]["HourlypayRate"].ToString();

                            label3.Visible = true;
                            label3txt.Visible = true;
                            label3.Text = "Overtime Hourly Pay Rate : ";
                            label3txt.Text = dt.Rows[i]["Overtime_HourlyRate"].ToString();


                            label4.Visible = true;
                            label4txt.Visible = true;
                            label4.Text = "Num of Regular Hours : ";
                            int regPay = Convert.ToInt32(dt.Rows[i]["TotalRegularPay"].ToString());
                            int HourlyPayRate = Convert.ToInt32(dt.Rows[i]["HourlypayRate"].ToString());

                            int numRegHrs = regPay / HourlyPayRate;
                            label4txt.Text = numRegHrs.ToString();

                            label5.Visible = true;
                            label5txt.Visible = true;

                            label5.Text = "Num of Overtime Hours : ";
                            int otPay = Convert.ToInt32(dt.Rows[i]["TotalOvertimePay"].ToString());
                            int HourlyOTPayRate = Convert.ToInt32(dt.Rows[i]["Overtime_HourlyRate"].ToString());

                            int numOTHrs = otPay / HourlyOTPayRate;
                            label5txt.Text = numOTHrs.ToString();

                            label6.Visible = true;
                            label6txt.Visible = true;
                            label6.Text = "Gross Pay : ";
                            label6txt.Text = dt.Rows[i]["GrossPay"].ToString();
                        }

                    }


                }
            }

            else if (actionFor.Text.Equals("Calculate Net Pay"))
            {
                //calculate Net Pay


                content.Text = "Following are the Net Pay details:";
                head.Text = "Net Pay";

                var stringvalue = "SELECT * FROM netpay where emp_id = " + employeeID;

                DataTable dt = dbObj.SelectQry(stringvalue);





                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string date = "" + dt.Rows[i]["PayStartDate"];
                        if (date.Equals(arrayelement[0]))
                        {


                            label1.Visible = true;
                            label1txt.Visible = true;
                            label1.Text = "Employee ID : ";
                            label1txt.Text = dt.Rows[i]["emp_id"].ToString();


                            label2.Visible = true;
                            label2txt.Visible = true;
                            label2.Text = "Gross Pay : ";
                            label2txt.Text = dt.Rows[i]["Gross_Amt"].ToString();

                            label3.Visible = true;
                            label3txt.Visible = true;
                            label3.Text = "Total Benefits : ";
                            label3txt.Text = dt.Rows[i]["Benefits_Amt"].ToString();


                            label4.Visible = true;
                            label4txt.Visible = true;
                            label4.Text = "Total Deductions : ";
                            label4txt.Text = dt.Rows[i]["Deductions_Amt"].ToString();


                            label5.Visible = true;
                            label5txt.Visible = true;
                            label5.Text = "Net Pay : ";
                            label5txt.Text = dt.Rows[i]["netpay_amt"].ToString();

                        }

                    }


                }
            }
            else if (actionFor.Text.Equals("Download Pay Check"))
            {
                //Download Pay Slip

                content.Text = "";
                head.Text = "My PaySlip";

                String stringvalue = "select * from employees e, grosspay g, netpay n where e.DocNum=" + employeeID + " and e.DocNum = g.Emp_ID and e.DocNum = n.Emp_ID;";
                DataTable dt = dbObj.SelectQry(stringvalue);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string date = "" + dt.Rows[i]["PayStartDate"];
                        if (date.Equals(arrayelement[0]))
                        {
                            String path = System.AppDomain.CurrentDomain.BaseDirectory;
                            String fileName = "payslip_"+employeeID+".pdf";
                            try
                            {
                                FileStream fs = new FileStream(System.AppDomain.CurrentDomain.BaseDirectory +"bin\\" + fileName, FileMode.Create, FileAccess.Write, FileShare.None);
                                iTextSharp.text.Document doc = new iTextSharp.text.Document();
                                iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs);
                                doc.Open();
                                String spacing = "                                                                                         ";
                                String imagepath = path + "Application\\Payroll\\Images\\HawkLogo.bmp";
                                //imagepath = "C:\\Users\\VJ\\Desktop\\HAWK 6\\Metro_Video_Photo_Fall_2016\\Metro_Video_Photo_Fall_2016\\Metro_Video_Photo_Fall_2016\\Application\\Payroll\\Images\\HawkLogo.bmp";

                                iTextSharp.text.Image gif = iTextSharp.text.Image.GetInstance(imagepath);



                                doc.Add(new Paragraph("-------------------------------------PAYSLIP - METRO VIDEO PHOTO -------------------------------------              "));
                                doc.Add(gif);
                                doc.Add(new Paragraph(spacing + "Employee ID : " + dt.Rows[i]["docnum"]));
                                doc.Add(new Paragraph(spacing + "First Name : " + dt.Rows[i]["firstname"]));
                                doc.Add(new Paragraph(spacing + "Last Name : " + dt.Rows[i]["lastname"]));
                                doc.Add(new Paragraph(spacing + "Email ID : " + dt.Rows[i]["email"]));
                                doc.Add(new Paragraph(" "));
                                doc.Add(new Paragraph(" "));
                                doc.Add(new Paragraph(" "));
                                doc.Add(new Paragraph(" "));
                                doc.Add(new Paragraph(" "));
                                doc.Add(new Paragraph("Pay Period:"));
                                doc.Add(new Paragraph("Start Date : " + dt.Rows[i]["PayStartDate"]));
                                doc.Add(new Paragraph("--------------------------------------------"));
                                doc.Add(new Paragraph("End Date : " + dt.Rows[i]["PayEndDate"]));
                                doc.Add(new Paragraph("---------------------------"));
                                doc.Add(new Paragraph("Total Overtime Pay : " + dt.Rows[i]["totalOvertimePay"]));
                                doc.Add(new Paragraph("---------------------------------------------"));
                                doc.Add(new Paragraph("Gross Pay : " + dt.Rows[i]["grosspay"]));
                                doc.Add(new Paragraph("--------------------------------------------"));
                                doc.Add(new Paragraph("Benefit Amount : " + dt.Rows[i]["benefits_amt"]));
                                doc.Add(new Paragraph("--------------------------------------------"));
                                doc.Add(new Paragraph("Deduction Amount : " + dt.Rows[i]["deductions_amt"]));
                                doc.Add(new Paragraph("--------------------------------------------"));
                                doc.Add(new Paragraph("Final Pay (Net Pay) : " + dt.Rows[i]["netpay_amt"]));



                                doc.Close();
                                string FileLocation = System.AppDomain.CurrentDomain.BaseDirectory + fileName;

                                //  String WatermarkLocation = Directory.GetCurrentDirectory();
                                String WatermarkLocation = path + "Application\\Payroll\\Images\\bgconfidential.png";
                                // WatermarkLocation = "C:\\Users\\VJ\\Desktop\\HAWK 6\\Metro_Video_Photo_Fall_2016\\Metro_Video_Photo_Fall_2016\\Metro_Video_Photo_Fall_2016\\Application\\Payroll\\Images\\bgconfidential.png";

                                Document document = new Document();
                                iTextSharp.text.pdf.PdfReader pdfReader = new iTextSharp.text.pdf.PdfReader(FileLocation);
                                iTextSharp.text.pdf.PdfStamper stamp = new iTextSharp.text.pdf.PdfStamper(pdfReader, new FileStream(FileLocation.Replace(".pdf", "_" + dt.Rows[0]["docnum"] + ".pdf"), FileMode.Create));

                                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(WatermarkLocation);
                                img.SetAbsolutePosition(0, 5); // set the position in the document where you want the watermark to appear (0,0 = bottom left corner of the page)

                                iTextSharp.text.pdf.PdfContentByte waterMark;
                                for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                                {
                                    waterMark = stamp.GetUnderContent(page);
                                    waterMark.AddImage(img);
                                }
                                stamp.FormFlattening = true;
                                stamp.Close();
                                PayslipMsg.Visible = true;
                                PayslipMsg.Text = "Your file (payslip.pdf) is succssfully downloaded";

                            }
                            catch (Exception ex)
                            { 
                                //cant be read

                            }

                        }

                    }

                }


            }
        }
    }
}
