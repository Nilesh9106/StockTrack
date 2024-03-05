using StockTrackClient.StoreService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockTrackClient
{
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] != null)
            {
                Response.Redirect("/");
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String name = usernameInput.Text;
            String email = emailInput.Text;
            String password = passwordInput.Text;
            Store store = new Store();
            store.Name = name;
            store.Email = email;
            store.Password = password;

            var client = new StoreServiceClient();

            var s = client.GetStoreByEmail(email);
            if (s != null)
            {
                errLabel.Text = "Email already exists!!";
                return;
            }

            s = client.AddStore(store);

            Session["email"] = email;
            Session["id"] = s.Id;
            Response.Redirect("/");
        }
    }
}