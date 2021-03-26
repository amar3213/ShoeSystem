using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;

public partial class DeleteCustomer : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customers to be deleted form the session object
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        DeleteRecord();
        //redirect back to the main page 
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("CustomerViewer.aspx");
    }


    void DeleteRecord()
    {
        //function to deleted the selected record

        //create a new instance
        clsCustomerCollection CustomerRecords = new clsCustomerCollection();
        //find the record ot delete
        CustomerRecords.ThisCustomer.Find(CustomerID);
        //deleted the record
        CustomerRecords.Delete();
    }
}