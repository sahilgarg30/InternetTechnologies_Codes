using System;

public partial class q4 : System.Web.UI.Page
{
    private static int count;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) count = 0;
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        if(TextBox1.Text == "qGphJD")
        {
            Label1.Text = "Correct!";
            count = 0;
        }
        else if(count < 3)
        {
            Label1.Text = "Wrong. You have " + (3 - count - 1) + " tries left.";
            count++;
            if (count == 3) TextBox1.Enabled = false;
        }
    }
}