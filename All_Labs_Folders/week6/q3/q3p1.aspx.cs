using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class q3p1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList1.Items.Add("summer");
            DropDownList1.Items.Add("winter");
        }

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["Theme"] = DropDownList1.SelectedItem.Text;
    }

    protected void Page_preInit(object sender, EventArgs e)
    {
        if (Session["Theme"] != null)
        {
            Page.Theme = Session["Theme"].ToString();
        }
    }
}