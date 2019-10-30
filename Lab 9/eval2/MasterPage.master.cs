using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    public string name;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
            label2.Text = value + " has registered successfully";
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}
