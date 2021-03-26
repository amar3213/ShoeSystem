using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoeClasses;

public partial class ACustomer : System.Web.UI.Page
{

    //var to store the address number
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the address no from the session object
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            if(CustomerID != -1)
            {
                DisplayCustomer();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (CustomerID == -1)
        {
            Add();
        }
        else
        {
            Update();
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
            //add the record
            CustomerRecords.Add();
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problem with the data entered - " + Error;

        }
    
    }

    void Update()

    {
        //create an instance of the customer records
        clsCustomerCollection CustomerRecords = new clsCustomerCollection();
        //validate the data on the web form 
        String Error = CustomerRecords.ThisCustomer.Valid(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtTeleNo.Text);
        //if the data is OK then add it the object
        if (Error == "")
        {
            CustomerRecords.ThisCustomer.Find(CustomerID);
            //get the data entered by the user
            CustomerRecords.ThisCustomer.CustomerFirstName = txtFirstName.Text;
            CustomerRecords.ThisCustomer.CustomerLastName = txtLastName.Text;
            CustomerRecords.ThisCustomer.CustomerEmail = txtEmail.Text;
            CustomerRecords.ThisCustomer.CustomerTeleNo = txtTeleNo.Text;
            CustomerRecords.ThisCustomer.Active = chkActive.Checked;
            //update the record
            CustomerRecords.Update();
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problem with the data entered - " + Error;

        }
    }

    //this function displays the data for an customer on the web form
    void DisplayCustomer()
    {
        //create an instance of the customer records
        clsCustomerCollection CustomerRecords = new clsCustomerCollection();
        //find the record we want to display
        CustomerRecords.ThisCustomer.Find(CustomerID);
        //display the date for thgis record
        txtFirstName.Text = CustomerRecords.ThisCustomer.CustomerFirstName;
        txtLastName.Text = CustomerRecords.ThisCustomer.CustomerLastName;
        txtEmail.Text = CustomerRecords.ThisCustomer.CustomerEmail;
        txtTeleNo.Text = CustomerRecords.ThisCustomer.CustomerTeleNo;
        chkActive.Checked = CustomerRecords.ThisCustomer.Active;
    }


    protected void btnDelete_Click(object sender, EventArgs e)
    {
  
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerViewer.aspx");
    }
}