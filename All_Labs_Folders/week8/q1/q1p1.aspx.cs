using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class q1p1 : System.Web.UI.Page
{

    static string conn = WebConfigurationManager.ConnectionStrings["staff"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            ListBox1.Items.Add("Kolkata");
            ListBox1.Items.Add("Mumbai");
            ListBox1.Items.Add("Hyderabad");
            SqlConnection nc = new SqlConnection(conn);
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select StaffID from Staff";
            cmd.Connection = nc;

            try
            {
                nc.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "test");
            }
            catch
            {
                Label1.Text = "Error";
            }
            finally { nc.Close(); }

            foreach (DataRow dr in ds.Tables["test"].Rows)
            {
                DropDownList1.Items.Add(dr["StaffID"].ToString());
            }
        }

         
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(conn))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "UPDATE Staff SET City=@c WHERE StaffId = @s";
                cmd.Parameters.AddWithValue("@c", ListBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@s", DropDownList1.SelectedValue);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                Response.Redirect("q1p1.aspx");
            }

        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string conn = WebConfigurationManager.ConnectionStrings["staff"].ConnectionString;
        SqlConnection nc = new SqlConnection(conn);
        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from Staff where StaffID = " + DropDownList1.SelectedItem.Text;
        cmd.Connection = nc;

        try
        {
            nc.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, "test");
        }
        catch
        {
            Label1.Text = "Error";
        }
        finally { nc.Close(); }

        DataRow dr = ds.Tables["test"].Rows[0];
        Label1.Text = dr["StaffID"] + " " + dr["FirstName"] + " " + dr["LastName"] + " " + dr["City"]; 
    }
}