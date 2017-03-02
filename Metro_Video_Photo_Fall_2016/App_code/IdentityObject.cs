using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro_Video_Photo_Fall_2016.App_code
{
    public class IdentityObject
    {

        #region Attributes

        private string _userID;
        private string _userName;
        private string _role;
        private int _dept;
        private string dept_name;

        public string Dept_name
        {
            get { return dept_name; }
            set { dept_name = value; }
        }
        private int _actionLevel;


        #endregion

        #region Constructors
        public IdentityObject()
        {
            UserID = "000";
            _userName = "guest";
            Role = "guest";
            _actionLevel = 0;
        }
        protected void SetIdentityObject(IdentityObject _ident)
        {
            UserID = _ident.UserID;
            UserName = _ident.UserName;
            Role = _ident.Role;
            ActionLevel = _ident.ActionLevel;
            Dept = _ident.Dept;
        }

        public IdentityObject(string userID, string userName, string role, int actionLevel, int dept)
        {
            UserID = userID;
            UserName = userName;
            Role = role;
            ActionLevel = actionLevel;
            Dept = dept;
        }

        #endregion

        #region Properties


        public string UserID
        {
            get
            {
                return _userID;
            }
            set
            {
                _userID = value;
            }
        }

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
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

        public int ActionLevel
        {
            get
            {
                return _actionLevel;
            }
            set
            {
                _actionLevel = value;
            }
        }

        public int Dept
        {
            get
            {
                return _dept;
            }
            set
            {
                _dept = value;
            }
        }
        #endregion

        #region Methods

        #endregion


    }
}