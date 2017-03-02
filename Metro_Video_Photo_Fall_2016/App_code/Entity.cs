using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Metro_Video_Photo_Fall_2016.App_code
{
    abstract class Entity
    {
        #region Attributes

        protected int _entityNum;
        protected int _entityType;
        protected string _name;
        protected string _name2;
        protected string _item4;
        protected string _item5;
        protected string _item6;
        protected string _item7;
        protected string _item8;
        protected string _item9;
        protected string _item10;
        protected string _item11;
        protected string _item12;
        protected string _item13;
        protected string _item14;
        protected string _item15;
        protected string _item16;

        #endregion

        #region Constructors
        public Entity()
        {
            string _record = "0, 0, , , , , , , , , , , , , , , , ";
            string[] _items = _record.Split(',');
            EntityNum = Int32.Parse(_items[0]);
            EntityType = Int32.Parse(_items[1]);
            Name = _items[2];
            Name2 = _items[3];
            Address = _items[4];
            Address2 = _items[5];
            City = _items[6];
            State = _items[7];
            PostalCode = _items[8];
            Country = _items[9];
            Phone = _items[10];
            Phone2 = _items[11];
            Email = _items[12];
            if (_items.Length > 13) Other1 = _items[13];
            if (_items.Length > 14) Other2 = _items[14];
            if (_items.Length > 15) Other3 = _items[15];
            if (_items.Length > 16) Comment = _items[16];

        }
        public Entity(string _record)
        {
            string[] _items = _record.Split(',');
            //  new   Entity( _items);
            EntityNum = Int32.Parse(_items[0]);
            EntityType = Int32.Parse(_items[1]);
            Name = _items[2];
            Name2 = _items[3];
            Address = _items[4];
            Address2 = _items[5];
            City = _items[6];
            State = _items[7];
            PostalCode = _items[8];
            Country = _items[9];
            Phone = _items[10];
            Phone2 = _items[11];
            Email = _items[12];
            if (_items.Length > 13) Other1 = _items[13];
            if (_items.Length > 14) Other2 = _items[14];
            if (_items.Length > 15) Other3 = _items[15];
            if (_items.Length > 16) Comment = _items[16];

        }
        public Entity(string[] _items)
        {
            EntityID = Int32.Parse(_items[0]);
            EntityType = Int32.Parse(_items[1]);
            Name = _items[2];
            Name2 = _items[3];
            Address = _items[4];
            Address2 = _items[5];
            City = _items[6];
            State = _items[7];
            PostalCode = _items[8];
            Country = _items[9];
            Phone = _items[10];
            Phone2 = _items[11];
            Email = _items[12];
            if (_items.Length > 13) Other1 = _items[13];
            if (_items.Length > 14) Other2 = _items[14];
            if (_items.Length > 15) Other3 = _items[15];
            if (_items.Length > 16) Comment = _items[16];
        }

        #endregion

        #region Properties


        public int EntityNum
        {
            get { return _entityNum; }
            set { _entityNum = value; }
        }

        public int EntityID
        {
            get { return _entityNum; }
            set { _entityNum = value; }
        }

        public int EntityType
        {
            get { return _entityType; }
            set { _entityType = value; }
        }

        public string FullName
        {
            get { return Name + " " + Name2; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Name2
        {
            get { return _name2; }
            set { _name2 = value; }
        }

        public string Address
        {
            get { return _item4; }
            set { _item4 = value; }
        }
        public string Address2
        {
            get { return _item5; }
            set { _item5 = value; }
        }

        public string City
        {
            get { return _item6; }
            set { _item6 = value; }
        }

        public string State
        {
            get { return _item7; }
            set { _item7 = value; }
        }

        public string PostalCode
        {
            get { return _item8; }
            set { _item8 = value; }
        }
        public string Country
        {
            get { return _item9; }
            set { _item9 = value; }
        }

        public string Email
        {
            get { return _item10; }
            set { _item10 = value; }
        }
        public string Phone
        {
            get { return _item11; }
            set { _item11 = value; }
        }
        public string Phone2
        {
            get { return _item12; }
            set { _item12 = value; }
        }

        public string NetAddress
        {
            get { return _item13; }
            set { _item13 = value; }
        }
        public string Other1
        {
            get { return _item13; }
            set { _item13 = value; }
        }

        public string AddressFull
        {
            get
            { return City.Trim() + ", " + State.Trim() + "  " + PostalCode; }
        }

        public string Other2
        {
            get { return _item14; }
            set { _item14 = value; }
        }

        public string Other3
        {
            get { return _item15; }
            set { _item15 = value; }
        }

        public string Other4
        {
            get { return _item16; }
            set { _item16 = value; }
        }
        public string Comment
        {
            get { return _item16; }
            set { _item16 = value; }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            string entityStr = String.Format("{0} ,{1} ,'{2}' ,'{3}' ,'{4}' ,'{5}' ,'{6}' ,'{7}' ,'{8}' ,'{9}' ,'{10}' ,'{11}' ,'{12}' ,'{13}' ,'{14}' ,'{15}' ,'{16}'",
                                        EntityNum, EntityType, Name, Name2, Address, Address2,
                                                                                   City, State, PostalCode, Country, Phone, Phone2, Email, Other1, Other2, Other3, Comment);
            return base.ToString();
        }
        #endregion
    }
}