using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;

public partial class ACustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the customer firstname
        string CustomerFirstName = txtFirstName.Text;
        //capture the last name
        string CustomerLastName = txtLastName.Text;
        //capture the email
        string CustomerEmail = txtEmail.Text;
        //capture the Tele no
        string CustomerTeleNo = txtTeleNo.Text;
        //store the customer in the seesion object
        string Error = "";
        //validate the error
        Error = ACustomer.Valid(CustomerFirstName, CustomerLastName, CustomerEmail, CustomerTeleNo);
        if (Error == "")
        {
            //capture the customer firstname
            ACustomer.CustomerFirstName = CustomerFirstName;
            //capture the last name
            ACustomer.CustomerLastName = CustomerLastName;
            //capture the email
            ACustomer.CustomerEmail = CustomerEmail;
            //capture the Tele no
            ACustomer.CustomerTeleNo = CustomerTeleNo;
            Session["ACustomer"] = ACustomer;
            //redirsect to the viewer page 
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void TextBox1_TextChanged1(object sender, EventArgs e)
    {

    }

    protected void txtFirstName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtLastName_TextChanged(object sender, EventArgs e)
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
        if(Found== true)
        {
            //dis;lay the values of the properties on the form 
            txtFirstName.Text = ACustomer.CustomerFirstName;
            txtLastName.Text = ACustomer.CustomerLastName;
            txtEmail.Text = ACustomer.CustomerEmail;
            txtTeleNo.Text = ACustomer.CustomerTeleNo;
        }

    }

    //function for adding new records 
    void Add()
    {
        //create an instance of the customer records
        clsCustomerCollection CustomerRecords = new clsCustomerCollection();
        //validate the data on the web form 
        String Error = CustomerRecords.ThisCustomer.Valid(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtTeleNo.Text);
        //if the data is OK then add it the object
        if (Error == "")
        {
            //get the data entered by the user
            CustomerRecords.ThisCustomer.CustomerFirstName = txtFirstName.Text;
            CustomerRecords.ThisCustomer.CustomerLastName = txtLastName.Text;
            CustomerRecords.ThisCustomer.CustomerEmail = txtEmail.Text;
            CustomerRecords.ThisCustomer.CustomerTeleNo = txtTeleNo.Text;
            CustomerRecords.ThisCustomer.Active = chkActive.Checked;
        }
        else
        {
            //report an error
            lblError.Text = "There were problem with the data entered" + Error;

        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the priamry key vlaue of the reocrd to be deleted
        Int32 CustomerID;
        //if the recrd has bee selected from the list
        if (lstCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the delete page
            Response.Redirect("Delete.aspx");
        }
        else
        {
            //display an eror
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}