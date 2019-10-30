using System;

public partial class q4page1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(TextBox1.Text == "abc" && TextBox2.Text == "123")
        {
            Session["count"] = 0;
            int x;
            if (Application["count"] == null)  x = 0;
            else  x = (int)Application["count"];
            x += 1;
            Application["count"] = x;
            Response.Redirect("q4page2.aspx");
        }
        else
        {
            int c;
            if(Session["count"]!=null) c = (int)Session["count"];
            else c = 0; 
            c = c + 1;
            Session["count"] = c;
            if (c >= 3)
            {
                Label1.Text = "You have 0 tries left.";
                TextBox1.Enabled = false;
                TextBox2.Enabled = false;
            }
            else
            {
                Label1.Text = "You have " + (3 - c) + " tries left.";
            }
        }
    }
}