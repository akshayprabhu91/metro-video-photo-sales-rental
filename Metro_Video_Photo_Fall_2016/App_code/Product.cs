using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro_Video_Photo_Fall_2016.App_code
{
    public class Product
    {

        #region Attributes

        private int _productID;
        private string _productName;
        private string _category;
        private int _productYear;
        private int _supplier;
        private string _maker;
        private string _model;
        private double _listPrice;
        private double _cost;
        private string _description;

        #endregion

        #region Constructors
        public Product(string record)
        {
            string[] field = record.Split(',');
            if (field.Length < 16) return;
            DocNum = Int32.Parse(field[0]);
            ProductName = field[1];
            Category = field[2];
            ProductYear = Int32.Parse(field[5]);
            Supplier = Int32.Parse(field[6]);
            Maker = field[3];
            Model = field[4];
            ListPrice = Double.Parse(field[7]);
            Cost = Double.Parse(field[8]);
            Description = field[16];
        }

        #endregion

        #region Properties


        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }
        public int DocNum
        {
            get { return _productID; }
            set { _productID = value; }
        }

        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
            }
        }

        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }

        public string Maker
        {
            get
            {
                return _maker;
            }
            set
            {
                _maker = value;
            }
        }


        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        public int ProductYear
        {
            get
            {
                return _productYear;
            }
            set
            {
                _productYear = value;
            }

        }

        public int Supplier
        {
            get
            {
                return _supplier;
            }
            set
            {
                _supplier = value;
            }

        }

        public double ListPrice
        {
            get
            {
                return _listPrice;
            }
            set
            {
                _listPrice = value;
            }
        }
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        #endregion

        #region Methods
        #endregion

    }
}