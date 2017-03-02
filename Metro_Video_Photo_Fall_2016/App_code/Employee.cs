using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro_Video_Photo_Fall_2016.App_code
{
    public class Employee
    {

        #region Attributes

        private int _docNum;
        private int _docType;
        private string _firstName;
        private string _lastName;
        private string _zipCode;
        public string _deptID;
        public string _role;
        public string _admLevel;
        public string _comment;
        public string Address;
        public string Address2;
        public string City;
        public string State;

        public string Country;
        public string Phone;
        public string Phone2;
        public string Email;
        #endregion

        #region Constructors

        public Employee(string _record)
        {
            string[] _items = _record.Split(',');
            EmployeeID = Int32.Parse(_items[0]);
            DocType = Int32.Parse(_items[1]);
            FirstName = _items[2];
            LastName = _items[3];
            Address = _items[4];
            Address2 = _items[5];
            City = _items[6];
            State = _items[7];
            ZipCode = _items[8];
            Country = _items[9];
            Phone = _items[10];
            Phone2 = _items[11];
            Email = _items[12];
            DeptID = (_items[13]);
            Role = _items[14];
            AdmLevel = (_items[15]);
            Comment = _items[16];
        }

        #endregion

        #region Properties

        public int DocNum
        {
            get
            {
                return _docNum;
            }
            set
            {
                _docNum = value;
            }
        }
        public int DocType
        {
            get
            {
                return _docType;
            }
            set
            {
                _docType = value;
            }
        }
        public int EmployeeID
        {
            get
            {
                return _docNum;
            }
            set
            {
                _docNum = value;
            }
        }


        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string WholeName
        {
            get
            {
                return FirstName + " " + LastName;
            }

        }


        public string ZipCode
        {
            get
            {
                return _zipCode;
            }
            set
            {
                _zipCode = value;
            }
        }

        public string DeptID
        {
            get
            {
                return _deptID;
            }
            set
            {
                _deptID = value;
            }
        }


        public string AdmLevel
        {
            get
            {
                return _admLevel;
            }
            set
            {
                _admLevel = value;
            }
        }

        public string Role
        {
            get
            {
                return _role;
            }
            set
            {
                _role = value;
            }
        }

        public string Comment
        {
            get
            {
                return _comment;
            }
            set
            {
                _comment = value;
            }
        }

        #endregion
    }
}