using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    string mobilename;

    public String MobileName
    {
        get { return mobilename; }
        set {
            mobilename = value;
            Label3.Text = value;
        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["name"] != null)
            Label3.Text = Session["name"].ToString();
    }
}
