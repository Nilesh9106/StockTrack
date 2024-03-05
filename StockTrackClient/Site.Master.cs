using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockTrackClient
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                loginbtn.Visible = true;
                logout.Visible = false;
                welcome.Text = string.Empty;
            }
            else
            {
                loginbtn.Visible = false;
                logout.Visible = true;
                welcome.Text = "welcome, " + Session["email"].ToString();
            }

            if (Session["smsg"] != null)
            {
                successlabel.Visible = true;
                successlabel.InnerText = Session["smsg"].ToString();
                Session["smsg"] = null;
            }
            if (Session["fmsg"] != null)
            {
                FailLabel.InnerText = Session["fmsg"].ToString();
                FailLabel.Visible = true;
                Session["fmsg"] = null;
            }
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("/login.aspx");
        }
    }
}