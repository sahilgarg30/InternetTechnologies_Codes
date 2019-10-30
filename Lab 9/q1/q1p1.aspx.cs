using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class q1p1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<String> fruits = new List<String>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Orange");

            cb1.DataSource = fruits;
            cb1.DataBind();

            List<String> icecream = new List<String>();
            icecream.Add("Vanilla");
            icecream.Add("Chocolate");
            icecream.Add("Mango");

            rb1.DataSource = icecream;
            rb1.DataBind();

        }


    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = rb1.SelectedItem.Text + " " + cb1.SelectedItem.Text;
    }
}