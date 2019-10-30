using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class q4p1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<String> cat = new List<String>();
            cat.Add("comedy");
            cat.Add("romance");
            DropDownList1.DataSource = cat;
            DropDownList1.DataBind();
        }
    }
}