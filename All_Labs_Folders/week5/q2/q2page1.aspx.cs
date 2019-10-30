using System;
using System.Web.UI.WebControls;


public partial class q2page1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)

    {

        if (!IsPostBack)

        {

            ddlSubjects.Items.Add(new ListItem("Maths"));

            ddlSubjects.Items.Add(new ListItem("Physics"));

            ddlSubjects.Items.Add(new ListItem("Biology"));

            ddlSubjects.Items.Add(new ListItem("Chemistry"));

            ddlSubjects.Items.Add(new ListItem("English"));

        }

    }



    protected void Button1_Click(object sender, EventArgs e)

    {

        Student s = new Student();

        s.Name = TxtName.Text.ToString();

        s.Roll = Convert.ToInt32(TxtRoll.Text.ToString());

        s.Subject = ddlSubjects.SelectedItem.ToString();

        Session["stud"] = s;

        Response.Redirect("q2page2.aspx");

    }
}