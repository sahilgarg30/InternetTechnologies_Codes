using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public partial class q2p1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Dictionary<int, string> movies = new Dictionary<int, string>();
        movies.Add(1, "comedy");
        movies.Add(2, "animated");
        movies.Add(3, "romance");

        if (!this.IsPostBack)
        {
            DropDownList1.DataSource = movies;
            DropDownList1.DataTextField = "Value";
            DropDownList1.DataValueField = "Key";
            DropDownList1.DataBind();
        }


    }

    protected void Drop_Change(object sender, EventArgs e)
    {
        ListBox1.Items.Clear();
        //Populate ListBox with Values from DropDownList Item
        SqlConnection scon = new SqlConnection();
        scon.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=HouseKeeping;Integrated Security=True";
        try
        {
            scon.Open();
            SqlCommand comm = new SqlCommand("SELECT name from Legends where category = @category", scon);
            comm.Parameters.AddWithValue("@category", DropDownList1.SelectedItem.Text);
            SqlDataReader reader;
            reader = comm.ExecuteReader();
            while (reader.Read())
            {
                ListBox1.Items.Add(reader["name"].ToString());
            }
        }
        catch
        { }
        finally
        {
            scon.Close();
        }
    }

    protected void List_Change(object sender, EventArgs e)
    {
        SqlConnection scon = new SqlConnection();
        scon.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=HouseKeeping;Integrated Security=True";
        try
        {
            scon.Open();
            SqlCommand comm = new SqlCommand("SELECT age from Legends where name = @name", scon);
            comm.Parameters.AddWithValue("@name", ListBox1.SelectedItem.Text);
            SqlDataReader reader;
            reader = comm.ExecuteReader();
            reader.Read();
            Name.Text = ListBox1.SelectedItem.Text;
            Age.Text = reader["age"].ToString();
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex);
        }
        finally
        {
            scon.Close();
        }
    }
}