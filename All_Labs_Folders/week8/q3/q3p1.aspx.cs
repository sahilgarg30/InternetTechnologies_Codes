using System;
using System.Data.SqlClient;

public partial class q3p1 : System.Web.UI.Page
{
    String cs = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=HouseKeeping;Integrated Security=True";

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDisplay_Click(object sender, EventArgs e)

    {

        lblDisplay.Text = String.Empty;

        using (SqlConnection con = new SqlConnection(cs))

        {
          using (SqlCommand cmd = new SqlCommand())

            {

                cmd.CommandText = "SELECT * FROM ITEM";

                cmd.Connection = con;

                con.Open();



                SqlDataReader rd = cmd.ExecuteReader();



                while (rd.Read())

                {

                    lblDisplay.Text += rd["Id"].ToString() + " " + rd["flavour"].ToString() + " " + rd["price"].ToString() + "<br/>";

                }

            }

        }



    }



    protected void btnAdd_Click(object sender, EventArgs e)

    {

        using (SqlConnection con = new SqlConnection(cs))

        {



            using (SqlCommand cmd = new SqlCommand())

            {
              cmd.CommandText = "INSERT INTO Item(Id,flavour) VALUES (@id,@flavor)";

                cmd.Parameters.AddWithValue("@id", txtItemid.Text);

                cmd.Parameters.AddWithValue("@flavor", txtFlavour.Text.ToString());

                cmd.Connection = con;

                con.Open();



                cmd.ExecuteNonQuery();

                txtItemid.Text = String.Empty;

                txtFlavour.Text = String.Empty;

            }

        }

    }



    protected void updateVanilla_Click(object sender, EventArgs e)

    {

        using (SqlConnection con = new SqlConnection(cs))

        {



            using (SqlCommand cmd = new SqlCommand())

            {

   
                cmd.CommandText = "UPDATE Item SET price=@pri WHERE flavour = 'vanilla'";

                cmd.Parameters.AddWithValue("@pri", txtVanila.Text);
                cmd.Connection = con;

                con.Open();



                cmd.ExecuteNonQuery();

                txtVanila.Text = String.Empty;

            }

        }

    }
}