using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro_Video_Photo_Fall_2016.App_code
{
    public class DocDetailItem
    {
        #region Attributes

        private int _docNum;
        private int _docType;
        private int _index1;
        private int _index2;
        private int _processID;
        private int _quantity;
        private double _price;
        private string _comment;

        #endregion

        #region Constructors
        public DocDetailItem()
        { }
        public DocDetailItem(string record)
        {
            char delim = ',';
            if (record.IndexOf(',') < 1) return;
            string[] fields = record.Split(delim);
            new DocDetailItem(fields);
        }
        public DocDetailItem(string[] field)
        {
            DocNum = Int32.Parse(field[0]);
            DocType = Int32.Parse(field[1]);
            Index1 = Int32.Parse(field[2]);
            Index2 = Int32.Parse(field[3]);
            ProcessID = Int32.Parse(field[4]);
            Quantity = Int32.Parse(field[5]);
            Price = Double.Parse(field[6]);
            if (field.Length > 7) Comment = field[7];
            else Comment = "";
        }


        #endregion

        #region Properties

        public int DocNum
        {
            get { return _docNum; }
            set { _docNum = value; }
        }

        public int DocType
        {
            get { return _docType; }
            set { _docType = value; }
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

        public int ProcessID
        {
            get { return ProcessID; }
            set { _processID = value; }
        }


        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            //return base.ToString();
            string _detailString = String.Format("{0} ,{1} ,{2} ,{3} ,{4} ,{5} ,{6} , {7}",
                                       DocNum, DocType, Index1, Index2, ProcessID, Quantity, Price, Comment);

            return _detailString;
        }

        #endregion


    }
}