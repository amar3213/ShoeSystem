using System;

namespace ShoeClasses
{
    public class clsStock
    {
        private int mID;
        public int ID
        {
            get
            {
                //this line of code sends data out of the property
                return mID;
            }
            set
            {
                //this line of code allows data into the property
                mID = value;
            }
        }
        private int mbrand;
        public int brand
        {
            get
            {
                //this line of code sends data out of the property
                return mbrand;
            }
            set
            {
                //this line of code allows data into the property
                mbrand = value;
            }
        }
        private string mname;
        public string name
        {
            get
            {
                //this line of code sends data out of the property
                return mname;
            }
            set
            {
                //this line of code allows data into the property
                mname = value;
            }
        }
        private int msize;
        public int size
        {
            get
            {
                //this line of code sends data out of the property
                return msize;
            }
            set
            {
                //this line of code allows data into the property
                msize = value;
            }
        }
        private DateTime mDate;
        public DateTime Date
        {
            get
            {
                //this line of code sends data out of the property
                return mDate;
            }
            set
            {
                //this line of code allows data into the property
                mDate = value;
            }
        }
        private int mquantity;
        public int quantity
        {
            get
            {
                //this line of code sends data out of the property
                return mquantity;
            }
            set
            {
                //this line of code allows data into the property
                mquantity = value;
            }
        }
        private int mcost;
        public int cost
        {
            get
            {
                //this line of code sends data out of the property
                return mcost;
            }
            set
            {
                //this line of code allows data into the property
                mcost = value;
            }
        }

        public bool Find(int iD)
        {
            //always return true
            return true;
        }

        public string Valid(string name)
        {
            throw new NotImplementedException();
        }
    }
}