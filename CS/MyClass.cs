using System;
using System.Linq;
using System.Collections.Generic;

namespace NewProject
{
    public class MyDataClass
    {
        public MyDataClass()
        {

        }
        // Fields...
        private DateTime _Date;
        private float _Sales;
        private int _ID;
        private string _Name;
        public int ID
        {
            get { return _ID; }
            set
            {
                _ID = value;
            }
        }
        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
            }
        }
        public float Sales
        {
            get { return _Sales; }
            set
            {
                _Sales = value;
            }
        }
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
    }
}
