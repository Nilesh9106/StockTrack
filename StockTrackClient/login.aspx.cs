using StockTrackClient.StoreService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockTrackClient
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] != null)
            {
                Response.Redirect("/home.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String email = emailInput.Text;
            String password = passwordInput.Text;

            var client = new StoreServiceClient();
            Response res = client.Verify(email, password);
            if(res.Code == 200)
            {
                Store store = client.GetStoreByEmail(email);
                if (store != null)
                {
                    Session["email"] = store.Email;
                    Session["id"] = store.Id;
                    Response.Redirect("/home.aspx");
                }
            }
            else
            {
                errLabel.Text = res.Message;
            }
        }
    }
}