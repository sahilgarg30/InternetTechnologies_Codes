using System;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class page1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            
        lstBackColor.Items.Add("White");
        lstBackColor.Items.Add("Red");
        lstBackColor.Items.Add("Green");
        lstBackColor.Items.Add("Blue");
        lstBackColor.Items.Add("Yellow");
        
        lstFontName.Items.Add("Times New Roman");
        lstFontName.Items.Add("Arial");
        lstFontName.Items.Add("Verdana");
        lstFontName.Items.Add("Tahoma");
        imgDefault.ImageUrl = "defaultpic.jpg";
    }
}
protected void cmdUpdate_Click(object sender, EventArgs e)
{
    pnlCard.BackColor = Color.FromName(lstBackColor.SelectedItem.Text);
    lblGreeting.Font.Name = lstFontName.SelectedItem.Text;
    if (Int32.Parse(txtFontSize.Text) > 0)
    {
        lblGreeting.Font.Size =
        FontUnit.Point(Int32.Parse(txtFontSize.Text));
    }
    if (chkPicture.Checked)
    {
        imgDefault.Visible = true;
    }
    else
    {
        imgDefault.Visible = false;
    }
    lblGreeting.Text = txtGreeting.Text;
}
}