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
        if (!IsPostBack) {
            DropDownList1.Items.Add("Student1");
            DropDownList1.Items.Add("Student2");
            DropDownList1.Items.Add("Student3");
            DropDownList1.Items.Add("Student4");

            RadioButtonList1.Items.Add("House1");
            RadioButtonList1.Items.Add("House2");
            RadioButtonList1.Items.Add("House3");
            RadioButtonList1.Items.Add("House4");

        }

    }

    protected void CustomValidator1_ServerValidate1(object source, ServerValidateEventArgs args)
    {    try
            {
                if (TextBox3.Text.Length == 10)
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
            catch
            {
                args.IsValid = false;
            }
        }
}