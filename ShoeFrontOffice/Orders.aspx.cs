using ShoeClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Orders : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsOrder Aorder = new clsOrder();
        Aorder.OrderItem = txtOrderID.Text;
        Session["Aorder"] = Aorder;
        Response.Redirect("OrderViewer.apsx");
    }
}