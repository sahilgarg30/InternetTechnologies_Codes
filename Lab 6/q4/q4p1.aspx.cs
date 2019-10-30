using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            DropDownList1.Items.Add("Samsung");
            DropDownList1.Items.Add("Apple");
            DropDownList1.Items.Add("Lenovo");
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        MasterPage page = (MasterPage)Master;
        page.MobileName = DropDownList1.SelectedItem.Text;
        Session["name"] = DropDownList1.SelectedItem.Text;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("q4p2.aspx");
    }
}