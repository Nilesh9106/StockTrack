using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockTrackClient.Products
{
    public partial class edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] == null)
            {
                Response.Redirect("/login.aspx");
            }
            if(Request.QueryString.Get("Id") == null)
            {
                Response.Redirect("/");
            }
            int id = int.Parse(Request.QueryString.Get("Id"));
            var client = new ProductService.ProductServiceClient();
            using (client)
            {
                ProductService.Product product = client.GetProductById(id);
                if (product != null)
                {
                    name.Text = product.Name;
                    desc.Text = product.Description;
                    price.Text = product.Price.ToString();
                    qty.Text = product.Qty.ToString();
                    brand.Text  = product.Brand.ToString();
                    category.Text = product.Category.ToString();
                }
            }
        }
        protected void btn_add_Click(object sender, EventArgs e)
        {
            ProductService.Product product = new ProductService.Product
            {
                Id = int.Parse(Request.QueryString.Get("Id")),
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
                client.UpdateProduct(product, int.Parse(Session["id"].ToString()));
                Response.Redirect("/");
            }
        }
    }
}