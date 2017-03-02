using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp;
using Metro_Video_Photo_Fall_2016.App_code;
using Metro_Video_Photo_Fall_2016.Database;
using System.Data;
using iTextSharp.text;
using System.IO;

namespace Metro_Video_Photo_Fall_2016.Application.Payroll
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int emp_id = 104;
        DataRow y;
        DB_Operations db = new DB_Operations();


        protected void Page_Load(object sender, EventArgs e)
        {
            string res = "select distinct start_date,end_date from Timesheets where emp_id = " + emp_id;
            DataTable queryList = db.SelectQry(res);
            ListBox1.Items.Add("Select startdate and end date");
            for (var i = 0; i < queryList.Rows.Count; i++)
            {
                ListBox1.Items.Add(queryList.Rows[i].ItemArray[0] + "  To " + queryList.Rows[i].ItemArray[1]);
            }
            //ListBox1.DataSource = queryList
            //Database.GetTables(ddlServers.Text, ddlDatabases.value);
            ListBox1.DataBind();
        }



        protected void button1_Click(object sender, EventArgs e)
        {
            var datecombination = ListBox1.SelectedValue.ToString();
            datecombination = datecombination.Replace(" To ", " , ");
            var arrayelement = datecombination.Split(',');
            string res = "select distinct start_date,end_date from Timesheets";
            DataTable queryList = db.SelectQry(res);
            arrayelement[0] = arrayelement[0].Remove(arrayelement[0].Length - 14);
            var stringvalue = "SELECT * FROM ([employees] AS [e] INNER JOIN [grosspay] AS [g] ON [e].[DocNum] = [g].[emp_id]) INNER JOIN [NETPAY] AS [N] ON [N].[emp_id]=[e].[DocNum] where [e].docNum=" + emp_id + " and [g].PayStartDate like '%" + arrayelement[0] + "%' and [N].PayStartDate like '%" + arrayelement[0] + "%'";
            var value = db.SelectQry(stringvalue);
            //value.Rows[0].ItemArray;

            String path = System.AppDomain.CurrentDomain.BaseDirectory;
            String fileName = "payslip.pdf";
            FileStream fs = new FileStream(System.AppDomain.CurrentDomain.BaseDirectory + fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs);
            doc.Open();
            String spacing = "                                                                                         ";
            String imagepath = path+ "Application\\Payroll\\Images\\HawkLogo.bmp";
            //imagepath = "C:\\Users\\VJ\\Desktop\\HAWK 6\\Metro_Video_Photo_Fall_2016\\Metro_Video_Photo_Fall_2016\\Metro_Video_Photo_Fall_2016\\Application\\Payroll\\Images\\HawkLogo.bmp";

            iTextSharp.text.Image gif = iTextSharp.text.Image.GetInstance(imagepath);



            doc.Add(new Paragraph("-------------------------------------PAYSLIP - METRO VIDEO PHOTO -------------------------------------              "));
            doc.Add(gif);
            doc.Add(new Paragraph(spacing + "Employee ID : " + value.Rows[0].ItemArray[0]));
            doc.Add(new Paragraph(spacing + "First Name : " + value.Rows[0].ItemArray[2]));
            doc.Add(new Paragraph(spacing + "Last Name : " + value.Rows[0].ItemArray[3]));
            doc.Add(new Paragraph(spacing + "Email ID : " + value.Rows[0].ItemArray[12]));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("Pay Period:"));
            doc.Add(new Paragraph("Start Date : " + value.Rows[0].ItemArray[23]));
            doc.Add(new Paragraph("--------------------------------------------"));
            doc.Add(new Paragraph("End Date : " + value.Rows[0].ItemArray[24]));
            doc.Add(new Paragraph("---------------------------"));
            doc.Add(new Paragraph("Total Overtime Pay : " + value.Rows[0].ItemArray[25]));
            doc.Add(new Paragraph("---------------------------------------------"));
            doc.Add(new Paragraph("Gross Pay : " + value.Rows[0].ItemArray[26]));
            doc.Add(new Paragraph("--------------------------------------------"));
            doc.Add(new Paragraph("Benefit Amount : " + value.Rows[0].ItemArray[31]));
            doc.Add(new Paragraph("--------------------------------------------"));
            doc.Add(new Paragraph("Deduction Amount : " + value.Rows[0].ItemArray[32]));
            doc.Add(new Paragraph("--------------------------------------------"));
            doc.Add(new Paragraph("Final Pay (Net Pay) : " + value.Rows[0].ItemArray[36]));



            doc.Close();
            string FileLocation = System.AppDomain.CurrentDomain.BaseDirectory + fileName;

          //  String WatermarkLocation = Directory.GetCurrentDirectory();
           String WatermarkLocation = path + "Application\\Payroll\\Images\\bgconfidential.png";
           // WatermarkLocation = "C:\\Users\\VJ\\Desktop\\HAWK 6\\Metro_Video_Photo_Fall_2016\\Metro_Video_Photo_Fall_2016\\Metro_Video_Photo_Fall_2016\\Application\\Payroll\\Images\\bgconfidential.png";

            Document document = new Document();
            iTextSharp.text.pdf.PdfReader pdfReader = new iTextSharp.text.pdf.PdfReader(FileLocation);
            iTextSharp.text.pdf.PdfStamper stamp = new iTextSharp.text.pdf.PdfStamper(pdfReader, new FileStream(FileLocation.Replace(".pdf", "_" + value.Rows[0].ItemArray[0] + ".pdf"), FileMode.Create));

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
            Label1.Visible = true;
            Label1.Text = "Your file (payslip.pdf) is succssfully downloaded";


        }
    }
}