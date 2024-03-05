using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockTrackClient.Transactions
{
    public partial class view : System.Web.UI.Page
    {
        TransactionService.TransactionServiceClient client;
        ProductService.ProductServiceClient productClient;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("/login.aspx");
            }
            
            client = new TransactionService.TransactionServiceClient();
            productClient = new ProductService.ProductServiceClient();

            List<ProductService.Product> p = productClient.GetProducts(int.Parse(Session["id"].ToString())).ToList();
            p.ForEach(item =>
            {
                Products.Items.Add(new ListItem(item.Name + "-" + item.Brand, item.Id.ToString()));
            });

            FetchTransactions();
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            RepeaterItem item = (sender as Button).NamingContainer as RepeaterItem;
            var id = (item.FindControl("itemId") as Label).Text;
            client.DeleteTransaction(int.Parse(id));
            FetchTransactions();
        }
        protected void btn_add_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(Quantity.Text);
            string type = Type.SelectedValue;
            int productId = int.Parse(Products.SelectedValue);
            int storeId = int.Parse(Session["id"].ToString());

            if(type == "sell") 
            {
                var product = productClient.GetProductById(productId);
                if (product.Qty < qty)
                {
                    Session["fmsg"] = "Qty is then required";
                    return;
                }
            }

            TransactionService.Transaction ob = new TransactionService.Transaction
            {
                Qty = qty,
                added = DateTime.Now,
                Type = type
            };
            client.AddTransaction(ob,storeId,productId);
            FetchTransactions();
        }

        protected void FetchTransactions()
        {
            if (Request.QueryString.Get("ProductId") == null)
            {
                var prods = client.GetTransactionsByStore(int.Parse(Session["id"].ToString()));
                transactions.DataSource = prods;
                transactions.DataBind();
            }
            else
            {
                var prods = client.GetTransactionsByProduct(int.Parse(Request.QueryString.Get("ProductId")));
                transactions.DataSource = prods;
                transactions.DataBind();
            }
        }
    }
}