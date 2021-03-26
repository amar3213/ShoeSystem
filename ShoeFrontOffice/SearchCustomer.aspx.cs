using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;


public partial class Search_Customer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an intance ofg the customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to sctor the primary key
        Int32 CustomerID;
        //variable to store the reiuslt of the find operation 
        Boolean Found = false;
        //get the primary key sented by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        Found = ACustomer.Find(CustomerID);
        //if found 
        if (Found == true)
        {
            //dis;lay the values of the properties on the form 
            txtFirstName.Text = ACustomer.CustomerFirstName;
            txtLastName.Text = ACustomer.CustomerLastName;
            txtEmail.Text = ACustomer.CustomerEmail;
            txtTeleNo.Text = ACustomer.CustomerTeleNo;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void txtLastName_TextChanged(object sender, EventArgs e)
    {

    }
}