using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Karnataka");
            dict.Add(2, "NCR");
            DropDownList1.DataSource = dict;
            DropDownList1.DataTextField = "value";
            DropDownList1.DataValueField = "key";
            DropDownList1.DataBind();
        } 
    }

}