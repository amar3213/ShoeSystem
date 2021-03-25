using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace ShoeStore
{
    public partial class StaffAdd : System.Web.UI.Page
    {
        public static clsStaffCollection StaffCollection = new clsStaffCollection();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //tries to insert data in database and list
            try
            {
                StaffCollection.addStaff(Convert.ToDateTime(txtEmployedDate.Text), txtName.Text, txtPhoneNumber.Text, Convert.ToDouble(txtSalary.Text), txtSurname.Text, Convert.ToDateTime(txtBirthDate.Text));
            }
            catch (Exception)
            {
                //if error
                lblSuccess.Text = "Record NOT saved!";
                lblSuccess.Visible = true;
                return;
            }
            //if success
            Response.Redirect("Staff.aspx");


        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Staff.aspx");
        }
    }
    
}