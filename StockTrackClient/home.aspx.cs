using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockTrackClient
{
    public partial class home : System.Web.UI.Page
    {
        ProductService.ProductServiceClient client;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("/login.aspx");
            }
            client = new ProductService.ProductServiceClient();
            FetchProducts();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            RepeaterItem item = (sender as Button).NamingContainer as RepeaterItem;
            var id = (item.FindControl("itemId") as Label).Text;
            client.DeleteProduct(int.Parse(id));
            FetchProducts();
        }
        protected void FetchProducts()
        {
            var prods = client.GetProducts(int.Parse(Session["id"].ToString()));
            products.DataSource = prods;
            products.DataBind();
        }
    }
}