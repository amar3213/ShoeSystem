using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace ShoeStore
{
    public partial class StaffUpdate : System.Web.UI.Page
    {
        public static clsStaffCollection StaffCollection = new clsStaffCollection();
        int staffId;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get possition and id of record to change
            this.staffId = Convert.ToInt32(Request.QueryString["id"]);
            StaffCollection.CurrentStaff = Convert.ToInt32(Request.QueryString["pos"]);

            //populate the textboxes
            if (!IsPostBack)
           {
                txtName.Text = StaffCollection.StaffList[StaffCollection.CurrentStaff].Name;
                txtSurname.Text = StaffCollection.StaffList[StaffCollection.CurrentStaff].Surname;
                txtBirthDate.Text = StaffCollection.StaffList[StaffCollection.CurrentStaff].BirthDate.ToString("dd/MM/yyyy");
                txtEmployedDate.Text = StaffCollection.StaffList[StaffCollection.CurrentStaff].EmployedDate.ToString("dd/MM/yyyy");
                txtPhoneNumber.Text = StaffCollection.StaffList[StaffCollection.CurrentStaff].PhoneNumber;
                txtSalary.Text = StaffCollection.StaffList[StaffCollection.CurrentStaff].Salary.ToString();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //tries to insert data in database and list
            try
            {
                StaffCollection.updateStaff(staffId,Convert.ToDateTime(txtEmployedDate.Text), txtName.Text, txtPhoneNumber.Text, Convert.ToDouble(txtSalary.Text), txtSurname.Text, Convert.ToDateTime(txtBirthDate.Text));
            }
            catch (Exception)
            {
                //if error
                lblSuccess.Text = "Record NOT updated!";
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