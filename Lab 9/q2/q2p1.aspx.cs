using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class q2p1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string url = "q2p2.aspx?Name=";
        url += HttpUtility.UrlEncode(ListBox1.SelectedItem.Text);
        Response.Redirect(url);
    }
}