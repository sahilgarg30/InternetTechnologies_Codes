using System;

public partial class q2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            employeeId.Items.Add("Employee 1");
            employeeId.Items.Add("Employee 2");
            imgDefault.Visible = false;
        }
    }
    protected void cmdUpdate_Click(object sender, EventArgs e)
    {
        imgDefault.Visible = true;
        if (employeeId.SelectedIndex == 0) imgDefault.ImageUrl = "name1.jpg";
        else imgDefault.ImageUrl = "name2.jpg";
        DateTime dt1 = DateTime.Parse(doj.Text.ToString());
        DateTime dt2 = DateTime.Now;
        dt2 = dt2.AddYears(-5);

        if (dt1.Date > dt2.Date )
        {
            eligible.Text = "NO";
        }
        else
        {
            eligible.Text = "YES";
        }
    }
}