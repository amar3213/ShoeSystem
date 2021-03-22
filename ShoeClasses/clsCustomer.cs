﻿using System;

namespace ShoeClasses
{
    public class clsCustomer
    {

        //private data member for the cutsomer id property
        private Int32 mCustomerID;
        //CustomerID public property
        public Int32 CustomerID
        {
            get
            {
                //this lione of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                //this line od code allows data into the property
                mCustomerID = value;
            }
        }

        //private data member for active
        private Boolean mActive;
        //public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }

        //private data member for first name
        private string mCustomerFirstName;
        //public property for first name
        public string CustomerFirstName
        {
            get
            {
                //return the private data
                return mCustomerFirstName;
            }
            set
            {
                //set the private data
                mCustomerFirstName = value;
            }
        }

        //private data member for last name
        private string mCustomerLastName;
        //public property for last name
        public string CustomerLastName
        {
            get
            {
                //return the private data
                return mCustomerLastName;
            }
            set
            {
                //set the private data
                mCustomerLastName = value;
            }
        }

        //private data member for email
        private string mCustomerEmail;
        //public property for email
        public string CustomerEmail
        {
            get
            {
                //return the private data
                return mCustomerEmail;
            }
            set
            {
                //set the private data
                mCustomerEmail = value;
            }
        }

        //private data member for tele no
        private string mCustomerTeleNo;
        //public property for tele no
        public string CustomerTeleNo
        {
            get
            {
                //return the private data
                return mCustomerTeleNo;
            }
            set
            {
                //set the private data
                mCustomerTeleNo = value;
            }
        }


        public bool Find(int CustomerID)
        {
            //initialise the DBConnection
            clsDataConnection dBConnection = new clsDataConnection();
            //add the device no parameter
            dBConnection.AddParameter("@CustomerID", CustomerID);
            //execute the query
            dBConnection.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if the record was found
            if (dBConnection.Count == 1)
            {
                //get the device no.
                mCustomerID = Convert.ToInt32(dBConnection.DataTable.Rows[0]["CustomerID"]);
                mCustomerFirstName = Convert.ToString(dBConnection.DataTable.Rows[0]["CustomerFirstName"]);
                mCustomerLastName = Convert.ToString(dBConnection.DataTable.Rows[0]["CustomerLastName"]);
                mCustomerEmail = Convert.ToString(dBConnection.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerTeleNo = Convert.ToString(dBConnection.DataTable.Rows[0]["CustomerTeleNo"]);
                mActive = Convert.ToBoolean(dBConnection.DataTable.Rows[0]["Active"]);
                return true;
            }
            //if no record was found
            else
            {
            //return indication a problem 
            return false;
            }
            
        }
    }
}