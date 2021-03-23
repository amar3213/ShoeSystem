using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace ShoeStore
{
    public partial class Staff : System.Web.UI.Page
    {
        public static clsStaffCollection StaffCollection = new clsStaffCollection();
        protected void Page_Load(object sender, EventArgs e)
        {
            //populate labels and buttons
            if (0 < StaffCollection.Size)
            {
                LabelRecPerTotal.Text = StaffCollection.CurrentStaff + 1+ "/" + StaffCollection.Size;
                LabelId.Text = StaffCollection.StaffList[StaffCollection.CurrentStaff].StaffId.ToString();
                LabelName.Text = StaffCollection.StaffList[StaffCollection.CurrentStaff].Name;
                LabelSurname.Text = StaffCollection.StaffList[StaffCollection.CurrentStaff].Surname;
                LabelBirthDate.Text = StaffCollection.StaffList[StaffCollection.CurrentStaff].BirthDate.ToString("dd/MM/yyyy");
                LabelEmployedDate.Text = StaffCollection.StaffList[StaffCollection.CurrentStaff].EmployedDate.ToString("dd/MM/yyyy");
                LabelPhoneNumber.Text = StaffCollection.StaffList[StaffCollection.CurrentStaff].PhoneNumber;
                LabelSalary.Text = StaffCollection.StaffList[StaffCollection.CurrentStaff].Salary.ToString()+ " &euro;";
                if (StaffCollection.CurrentStaff == StaffCollection.Size-1)
                {
                    btnNext.Enabled = false;
                }
                else
                {
                    btnNext.Enabled = true; ;
                }
                if (StaffCollection.CurrentStaff == 0)
                {
                    btnPrevious.Enabled = false;
                }
                else
                {
                    btnPrevious.Enabled = true;
                }
                if (StaffCollection.Size == 0)
                {
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
        }

        //show next staff item from list
        protected void btnNext_Click(object sender, EventArgs e)
        {
            StaffCollection.CurrentStaff = StaffCollection.nextStaff();
            Response.Redirect("Staff.aspx");
        }

        //show previous staff item from list
        protected void btnPrevious_Click(object sender, EventArgs e)
        {
            StaffCollection.CurrentStaff = StaffCollection.previousStaff();
            Response.Redirect("Staff.aspx");
        }

        //delete shown staff item from database and list
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            StaffCollection.deleteStaff(StaffCollection.CurrentStaff);
            Response.Redirect("Staff.aspx");
        }

        //add new item staff
        protected void btnNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffAdd.aspx");
        }

        //edit shown item staff
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffUpdate.aspx?id="+StaffCollection.StaffList[StaffCollection.CurrentStaff].StaffId+"&pos="+ StaffCollection.CurrentStaff);
        }
    }
}