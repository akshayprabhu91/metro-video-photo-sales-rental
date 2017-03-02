using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro_Video_Photo_Fall_2016.App_code
{
    class Supplier
    {
        #region Attributes

        private int _supplierID;
        private string _name;
        private string _address;
        private string _address2;
        private string _city;
        private string _state;
        private string _postalCode;
        private string _country;
        private double _amountDue;
        private string _phone;
        private string _email;

        #endregion

        #region Constructors
        public Supplier(string _record)
        {
            string[] _items = _record.Split(',');
            SupplierID = Int32.Parse(_items[0]);
            Name = _items[1];
            Address = _items[2];
            Address2 = _items[3];
            City = _items[4];
            State = _items[5];
            PostalCode = _items[6];
            Country = _items[7];
            AmountDue = Double.Parse(_items[8]);
            Phone = _items[9];
            Email = _items[10];
        }

        #endregion

        #region Properties


        public int SupplierID
        {
            get
            {
                return _supplierID;
            }
            set
            {
                _supplierID = value;
            }
        }


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }


        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        public string Address2
        {
            get
            {
                return _address2;
            }
            set
            {
                _address2 = value;
            }
        }

        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }
        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }
        public string PostalCode
        {
            get
            {
                return _postalCode;
            }
            set
            {
                _postalCode = value;
            }
        }
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        public string AddressFull
        {
            get
            {
                return City.Trim() + ", " + State.Trim() + "  " + PostalCode;
            }

        }

        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }

        public double AmountDue
        {
            get
            {
                return _amountDue;
            }
            set
            {
                _amountDue = value;
            }
        }



        #endregion

        #region Methods

        #endregion


    }
}