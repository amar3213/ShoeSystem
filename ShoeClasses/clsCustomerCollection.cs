using System;
using System.Collections.Generic;

namespace ShoeClasses
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private the data member thiscustomer
        clsCustomer mThisCustomer = new clsCustomer();

        //public property for the address list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the private data
                return mCustomerList.Count;
            }
            set
            {
                
            }
        }

        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set theprivate data
                mThisCustomer = value;
            }
        }

        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //car to store the record count
            Int32 RecordCount = 0;
            //object fro data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the cound of records
            RecordCount = DB.Count;
            //while threre are records to process
            while (Index < RecordCount)
            {
                //create a vlank customer
                clsCustomer ACustomer = new clsCustomer();
                //read the fields form the current record
                ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.CustomerFirstName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFirstName"]);
                ACustomer.CustomerLastName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerLastName"]);
                ACustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                ACustomer.CustomerTeleNo = Convert.ToString(DB.DataTable.Rows[Index]["CustomerTeleNo"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at hte nexxt record
                Index++;
            }
        }

        public int Add()
        {
            //add a new record to the database based on the values on mThisCustomer
            //connect to the datbase 
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerFirstName", mThisCustomer.CustomerFirstName);
            DB.AddParameter("@CustomerLastNamer", mThisCustomer.CustomerLastName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerTeleNo", mThisCustomer.CustomerTeleNo);
            DB.AddParameter("@Active", mThisCustomer.Active);
            //execute the stored procedure returning the primary key val of hte new record 
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }
    }
}