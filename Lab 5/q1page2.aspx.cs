﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)

    {

        Label1.Text = Request.QueryString["Model"];

        Label2.Text = Request.QueryString["Make"];

    }
}