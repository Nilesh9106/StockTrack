using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockTrackClient.Products
{
    public partial class add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("/login.aspx");
            }

        }
        protected void btn_add_Click(object sender, EventArgs e)
        {
            ProductService.Product product = new ProductService.Product { 
                Name = name.Text,
                Description = desc.Text,
                Price = int.Parse(price.Text),
                Qty = int.Parse(qty.Text),
                Brand = brand.Text,
                Category = category.Text,
            };
            var client = new ProductService.ProductServiceClient();
            using (client)
            {
                client.AddProduct(product, int.Parse(Session["id"].ToString()));
                Response.Redirect("/");
            }
        }
    }
}