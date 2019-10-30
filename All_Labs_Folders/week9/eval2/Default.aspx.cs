using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string cs = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=HouseKeeping;Integrated Security=True";
        using (SqlConnection con = new SqlConnection(cs))

        {
            using (SqlCommand cmd = new SqlCommand())

            {

                cmd.CommandText = "Insert into Alumni values (@name,@phone,@place)";

                cmd.Connection = con;

                con.Open();

                cmd.Parameters.AddWithValue("@name", TextBox1.Text);

                cmd.Parameters.AddWithValue("@phone", TextBox2.Text);

                cmd.Parameters.AddWithValue("@place", TextBox3.Text);

                cmd.ExecuteNonQuery();

            }

        }

        TextBox1.Visible = false;
        TextBox2.Visible = false;
        TextBox3.Visible = false;
        MasterPage mp = (MasterPage)Master;
        mp.Name = TextBox1.Text;
    }
}