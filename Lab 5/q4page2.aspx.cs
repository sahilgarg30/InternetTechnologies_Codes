using System;

public partial class q4page2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Application["count"] == null) Label1.Text = "0";
        else Label1.Text = Application["count"].ToString();
    }
}