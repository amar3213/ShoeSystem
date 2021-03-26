using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;

public partial class CustomerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirect to the data entry page
        
        Response.Redirect("ACustomer.aspx");
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Response.Redirect("SearchCustomer.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the edit page
            Response.Redirect("ACustomer.aspx");
        }
        else//if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the delete page
            Response.Redirect("DeleteCustomer.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayAddresses function to the record count var
        RecordCount = DisplayCustomers("");
        //display the number of records found
        lblError.Text = RecordCount + " records in the database";
        //clear the post code filter text box
        txtEmailBox.Text = "";
    }

    //function use to populate the list box
    Int32 DisplayCustomers(string CustomerEmailFilter)
    { 

        //create a new instance of the clsAddress
        clsCustomerCollection MyCustomerList = new clsCustomerCollection();
        //var to store the count of records
        Int32 RecordCount;
        //var to store the house no
        string CustomerFirstName;
        //var to store the street name
        string CustomerLastName;
        //var to store the post code
        string CustomerEmail;
        //var to store the primary key value
        string CustomerID;
        //var to store the index
        Int32 Index = 0;
        //clear the list of any existing items
        lstCustomers.Items.Clear();
        //call the filter by post code method
        MyCustomerList.ReportByEmail(CustomerEmailFilter);
        //get the count of records found
        RecordCount = MyCustomerList.Count;
        //loop through each record found using the index to point to each record in the data table
        while (Index < RecordCount)
        {
            //get the house no from the query results
            CustomerFirstName = Convert.ToString(MyCustomerList.CustomerList[Index].CustomerFirstName);
            //get the street from the query results
            CustomerLastName = Convert.ToString(MyCustomerList.CustomerList[Index].CustomerLastName);
            //get the post code from the query results
            CustomerEmail = Convert.ToString(MyCustomerList.CustomerList[Index].CustomerEmail);
            //get the address no from the query results
            CustomerID = Convert.ToString(MyCustomerList.CustomerList[Index].CustomerID);
            //set up a new object of class list item 
            ListItem NewItem = new ListItem(CustomerFirstName + " " + CustomerLastName + "    -    " + CustomerEmail, CustomerID);
            //add the new item to the list
            lstCustomers.Items.Add(NewItem);
            //increment the index
            Index++;
        }
        //return the number of records found
        return RecordCount;
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //declare var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayAddresses function to the record count var
        RecordCount = DisplayCustomers(txtEmailBox.Text);
        //display the number of records found
        lblError.Text = RecordCount + " records found";
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

    }
}