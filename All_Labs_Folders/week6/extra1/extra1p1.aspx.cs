using System;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Linq;

public partial class extra1p1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList1.Items.Add("email");
            DropDownList1.Items.Add("phone");
            DropDownList1.Items.Add("user");
        }
    }

    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if(DropDownList1.SelectedItem.Text == "email")
        {
            Regex reg = new Regex(@"\w*@\w*\.(com)");
            Match m = reg.Match(TextBox1.Text);
            if (m.Success)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
                CustomValidator1.ErrorMessage = "wrong email";
            }
        }else if(DropDownList1.SelectedItem.Text == "phone")
        {
            if (TextBox1.Text.All(Char.IsDigit))
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
                CustomValidator1.ErrorMessage = "wrong phone";
            }
            
        }
        else
        {
            if (TextBox1.Text.All(Char.IsUpper))
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
                CustomValidator1.ErrorMessage = "wrong user";
            }
        }
    }
}