using System;
using System.Web;

public partial class q3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ListBox1.Items.Add("Burger");
            ListBox1.Items.Add("Pizza");
            ListBox1.Items.Add("Phone");
            ListBox1.Items.Add("Laptop");
        }

        HttpCookie cookie = Request.Cookies["carts"];
        if(cookie != null)
        {
            TextBox1.Text = cookie["name"];
            TextBox3.Text = cookie["list"];
        }
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        if(ListBox1.SelectedIndex != -1) TextBox3.Text += " "+ListBox1.SelectedItem.Text;
        HttpCookie cookie = Request.Cookies["carts"];
        if (cookie == null) cookie = new HttpCookie("carts");
        cookie["name"] = TextBox1.Text;
        cookie["list"] = TextBox3.Text;
        cookie.Expires = DateTime.Now.AddYears(1);
        Response.Cookies.Add(cookie);
    }
}