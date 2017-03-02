using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro_Video_Photo_Fall_2016.App_code
{
    public class Process
    {
        int _transactionID;
        int _transType;
        int _index1;
        int _index2;
        DateTime _transDate;
        int _status;
        double _transAmount;
        string _description;
        string _comment;

        public Process() { }
        public Process(string[] fields)
        {
            _transactionID = Int32.Parse(fields[0]);
            _transType = Int32.Parse(fields[1]);   // fields[3].Trim();
            _index1 = Int32.Parse(fields[2]);
            _index2 = Int32.Parse(fields[3]);
            _transDate = DateTime.Parse(fields[4]);
            _status = Int32.Parse(fields[5]);
            _transAmount = double.Parse(fields[6]);
            _description = fields[7].Trim();
            _comment = fields[8].Trim();
        }
        public int TransactionID
        {
            get { return _transactionID; }
            set { _transactionID = value; }
        }
        public int TransType
        {
            get { return _transType; }
            set { _transType = value; }
        }
        public int Index1
        {
            get { return _index1; }
            set { _index1 = value; }
        }

        public int Index2
        {
            get { return _index2; }
            set { _index2 = value; }
        }

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        public DateTime TransDate
        {
            get { return _transDate; }
            set { _transDate = value; }
        }

        public double TransAmount
        {
            get { return _transAmount; }
            set { _transAmount = value; }
        }

        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string ToString(int recordType)
        {
            /* switch (recordType)
             {
                 case 1:
              */
            string dString = TransDate.ToShortDateString();
            return String.Format("{0,6} {1,4}   {2,9}   {3,4}   {4,4} {5,12:n2} {6,4}   {7,-32} ",
                    TransactionID, TransType, dString, Index1, Index2, TransAmount, Status, Description.PadRight(25));
            //            0             1        2         3      4             5         6      

            /*
           case 8:
               return String.Format("{0,120}  {1,10}  {2,20}  {3,10}", " ", "-------- ", "  ", "-------- ");
               
           case 9:
               return String.Format("{0,120}  {1,10}  {2,20}  {3,10}", " ", " ", "  ", " ");
              
                     
                 return String.Format("{0,8}  {1,10}  {2,10}  {3,10}  {4,20} {5,20} {6,20:C}  ",
                     _transactionID,_transactionItemID, Trans_Index, RecordType, "  ",Description, Total);
              */
            //      0                   1             2             3     4        5         6
        }
    }  //  end of class
}