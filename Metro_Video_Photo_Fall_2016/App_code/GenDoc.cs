using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro_Video_Photo_Fall_2016.App_code
{
    public class GenDoc
    {
        #region Attributes

        protected int _docNum;
        protected int _docType;
        protected int _externalRef;
        protected int _internalRef;
        protected double _status;
        protected int _docRef;
        protected string _textValue1;
        protected string _textValue2;
        protected decimal _numAmount1;
        protected decimal _numAmount2;
        protected string _comment;


        private List<DocDetailItem> _docDetails;

        #endregion

        #region Constructors
        public GenDoc()
        { }
        public GenDoc(string record)
        {
            string[] fields = record.Split(',');
            new GenDoc(fields);
        }
        public GenDoc(string[] field)
        {
            DocNum = Int32.Parse(field[0]);
            DocType = Int32.Parse(field[1]);
            ExternalAgent = Int32.Parse(field[2]);
            InternalAgent = Int32.Parse(field[3]);
            Status = Int32.Parse(field[4]);
            ProcessID = Int32.Parse(field[5]);
            TextValue1 = field[6];
            TextValue2 = field[7];
            // StatusDate = DateTime.FromOADate(double.Parse(field[7]));
            QuotedAmount = decimal.Parse(field[8]);
            ActualAmount = decimal.Parse(field[9]);
            Comment = field[10];
        }
        public GenDoc(List<string> records)
        {
            int linecount = records.Count;
            string[] field = records[0].Split(',');
            DocNum = Int32.Parse(field[0]);
            DocType = Int32.Parse(field[1]);
            ExternalAgent = Int32.Parse(field[2]);
            InternalAgent = Int32.Parse(field[3]);
            DStatus = Double.Parse(field[4]);
            ProcessID = Int32.Parse(field[5]);
            TextValue1 = (field[6]);
            TextValue2 = (field[7]);
            QuotedAmount = decimal.Parse(field[8]);
            ActualAmount = decimal.Parse(field[9]);
            Comment = field[10];
            _docDetails = new List<DocDetailItem>();
            for (int i = 1; i < linecount; i++)
            {
                string[] nextRecord = records[i].Split(',');
                if (nextRecord.Length > 8)
                {
                    //  (" record longer than 8 fields");
                    continue;
                }
                //   DocDetailItem detailItem = new DocDetailItem(records[i]);
                //   _docDetails.Add(detailItem);
            }
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

        public int ProcessID
        {
            get { return _docRef; }
            set { _docRef = value; }
        }

        public decimal QuotedAmount
        {
            get { return _numAmount1; }
            set { _numAmount1 = value; }
        }
        public decimal NumAmount1
        {
            get { return _numAmount1; }
            set { _numAmount1 = value; }
        }

        public decimal ActualAmount
        {
            get { return _numAmount2; }
            set { _numAmount2 = value; }
        }

        public decimal NumAmount2
        {
            get { return _numAmount2; }
            set { _numAmount2 = value; }
        }

        public int ExternalAgent
        {
            get { return _externalRef; }
            set { _externalRef = value; }
        }


        public int InternalAgent
        {
            get { return _internalRef; }
            set { _internalRef = value; }
        }
        public int ExternalRef
        {
            get { return _externalRef; }
            set { _externalRef = value; }
        }


        public int InternalRef
        {
            get { return _internalRef; }
            set { _internalRef = value; }
        }

        public string StartDateStr
        {
            get { return _textValue1; }
            set { _textValue1 = value; }
        }
        public string TextValue1
        {
            get { return _textValue1; }
            set { _textValue1 = value; }
        }

        public string TextValue2
        {
            get { return _textValue2; }
            set { _textValue2 = value; }
        }

        public string StatusDateStr
        {
            get { return _textValue2; }
            set { _textValue2 = value; }
        }
        public DateTime StatusDate
        {
            get { return DateTime.Parse(_textValue2); }
            set { _textValue2 = value.ToShortDateString(); }
        }

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        public double DStatus
        {
            get { return _status; }
            set { _status = value; }
        }
        public int Status
        {
            get { return (int)_status; }
            set { _status = value; }
        }

        public List<DocDetailItem> DocDetails
        {
            get { return _docDetails; }
            set { _docDetails = value; }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            //return base.ToString();
            string _poString = String.Format("{0} ,{1} ,{2} ,{3} ,{4} ,{5} ",  //,{6} ,{7} ,{8} ,{9} ,{10} ,{11} ",
                                       DocNum, DocType, ExternalRef, InternalRef, Status, ProcessID);
            //               ProcessID, TextValue1, TextValue2 , NumAmount1,  NumAmount2, Comment);
            return _poString;
        }
        //public virtual int GetDocument(int inDocNum, int inDocType)
        //{
        //    string docName = "GenDocs";
        //    string cmdString = String.Format("select * from {0} where DucNum = {1} and DocType = {2}", docName, inDocNum, inDocType);
        //    List<string> mainString = DbUtility.GetList(cmdString);
        //    if (mainString.Count < 2) return 0;
        //    if (mainString.Count > 2) return 3;
        //    //  count = 2, therefore found 1 data record and 1 string of names
        //    new GenDoc(mainString[1]);
        //    cmdString = String.Format("select * from {0}_Details where DucNum = {1} and DocType = {2}", docName, inDocNum, inDocType);
        //    List<string> detailStrings = DbUtility.GetList(cmdString);
        //    if (detailStrings.Count < 2) return 0;
        //    for (int i = 1; i < detailStrings.Count; i++)
        //    {
        //        DocDetailItem _item = new DocDetailItem(detailStrings[i]);
        //    }
        //    return detailStrings.Count - 1;
        //}
        public virtual List<string> GetDocument(string tablename, int inDocNum, int inDocType)
        {
            string cmdString = String.Format("select * from {0} where DucNum = {1} and DocType = {2}", tablename, inDocNum, inDocType);
            List<string> mainString = new List<string>();
            mainString = DataBaseUtility.GetList(cmdString);
            if (mainString.Count < 2)
            {
                return mainString;
            }
            //  if (mainString.Count > 2) return 3;
            //  count = 2, therefore found 1 data record and 1 string of names
            new GenDoc(mainString[1]);
            cmdString = String.Format("select * from DocumentDetails where DucNum = {0} and DocType = {1}, inDocNum, inDocType");
            List<string> detailStrings = DataBaseUtility.GetList(cmdString);
            if (detailStrings.Count < 2) return mainString;
            for (int i = 1; i < detailStrings.Count; i++)
            {
                DocDetailItem _item = new DocDetailItem(detailStrings[i]);
            }
            return mainString;
        }
        public int SaveDocument(IdentityObject ident, string _tableName, string inDocNum, string inDocType, List<string> myData)
        {
            int retCode = 0;
            //  DocNum = inDocNum;
            DocNum = Int32.Parse(inDocNum);
            DocType = Int32.Parse(inDocType);
            string cmdString = String.Format("insert into {0} Values ({1})", _tableName.Trim(), myData[0]);    //where DocNum = {1} and DocType = {2}", _tableName, inDocNum, inDocType);
            string retMessage = DataBaseUtility.Execute(cmdString, ident);
            // if (mainString.Count < 2) return 0;   
            // if (mainString.Count > 2) return 3;
            //  count = 2, therefore found 1 data record and 1 string of names
            //  new GenDoc(mainString[1]);
            //  cmdString = String.Format("select * from DocumentDetails where DucNum = {0} and DocType = {1}, inDocNum, inDocType");
            //  List<string> detailStrings = DbUtility.GetList(cmdString);
            if (myData.Count < 2) return 0;
            for (int i = 1; i < myData.Count; i++)
            {
                string cmdString2 = String.Format("insert into {0}_Details  Values ({1})", _tableName.Trim(), myData[i]);
                string retMessage2 = DataBaseUtility.Execute(cmdString2, ident);

            }
            return retCode;


        }

        #endregion

    }
}