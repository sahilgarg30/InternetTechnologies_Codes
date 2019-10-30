using System;
using System.Data.SqlClient;
public partial class q4p1 : System.Web.UI.Page
{
    static string cs = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=HouseKeeping;Integrated Security=True";

    protected void Page_Load(object sender, EventArgs e)

    {



    }



    protected void Button1_Click(object sender, EventArgs e)

    {

        
        using (SqlConnection con = new SqlConnection(cs))

        {



            using (SqlCommand cmd = new SqlCommand())

            {



                cmd.CommandText = "INSERT INTO WORKS(person_name,company_name,salary) VALUES (@a,@c,@s)";

                cmd.Parameters.AddWithValue("@a", pname.Text);

                cmd.Parameters.AddWithValue("@c", cname.Text);

                cmd.Parameters.AddWithValue("@s", sal.Text);

                cmd.Connection = con;

                con.Open();



                cmd.ExecuteNonQuery();

                pname.Text = String.Empty;

                cname.Text = String.Empty;

                sal.Text = String.Empty;







            }

        }

    }



    protected void Button2_Click(object sender, EventArgs e)

    {

        
        using (SqlConnection con = new SqlConnection(cs))

        {



            using (SqlCommand cmd = new SqlCommand())

            {

                cmd.CommandText = "SELECT w.person_name,city from WORKS w,LIVES l where company_name=@company  and w.person_name=l.person_name;";

                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@company", txtCname.Text);

                con.Open();



                SqlDataReader rd = cmd.ExecuteReader();



                while (rd.Read())

                {

                    Label1.Text += rd["person_name"].ToString() + " " + rd["city"].ToString() + "<br/>";

                }

            }

        }



    }
}