<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="view.aspx.cs" EnableEventValidation="false"  Inherits="StockTrackClient.Transactions.view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Transactions</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="my-3 p-5 card">
        <div class="my-2  form-group">
            <asp:Label ID="labelQuantity" CssClass="mb-2" runat="server" AssociatedControlID="Quantity" Text="Quantity"></asp:Label>
            <asp:TextBox ID="Quantity" CssClass="form-control" runat="server" TextMode="Number"></asp:TextBox>
        </div>
        <div class="my-2 form-group">
            <asp:Label ID="labelType" CssClass="mb-2" runat="server" AssociatedControlID="Type" Text="Type"></asp:Label>
            <asp:DropDownList ID="Type" CssClass="form-control" runat="server">
                <asp:ListItem Text="Sell" Value="sell"></asp:ListItem>
                <asp:ListItem Text="Buy" Value="buy"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="my-2 form-group">
            <asp:Label ID="label1" runat="server" CssClass="mb-2" AssociatedControlID="Products" Text="Product"></asp:Label>
            <asp:DropDownList ID="Products" CssClass="form-control" runat="server">
            </asp:DropDownList>
        </div>
        <asp:Button CssClass="btn btn-dark w-100" Text="Add" runat="server" ID="btn_add" OnClick="btn_add_Click" />
    </div>
    <asp:Repeater ID="transactions" runat="server">
        <HeaderTemplate>
            <h1>Transactions</h1>
            <div class="accordion" id="accordion">
        </HeaderTemplate>
        <ItemTemplate>
            <div class="accordion-item">
                <asp:Label ID="itemId" runat="server"  Text='<%#Eval("Id")%>' Visible="false"> </asp:Label>
                <h2 class="accordion-header">
                    <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapse<%#Eval("Id") %>" aria-expanded="false" aria-controls="collapse<%#Eval("Id") %>">
                        <%#Eval("Product.Name") %> - <%#Eval("Type") %>
                    </button>
                </h2>
                <div id="collapse<%#Eval("Id") %>" class="accordion-collapse collapse " data-bs-parent="#accordion">
                    <div class="accordion-body">
                        <div class="card" style="width: 100%;">
                            <ul class="list-group list-group-flush">
                                <li class="list-group-item">Type : <%#Eval("Type") %></li>
                                <li class="list-group-item">Qty : <%#Eval("Qty") %></li>
                                <li class="list-group-item">Price : <%#Eval("Product.Price") %></li>
                                <li class="list-group-item">Date : <%#Eval("added") %></li>
                            </ul>
                            <div class="card-body d-flex gap-2">
                                <asp:Button CssClass="btn btn-danger" runat="server" ID="btnDelete" Text="Delete" OnClientClick="return confirm('are you sure to delete this transaction??')" OnClick="btnDelete_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>
        <FooterTemplate>
            </div>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
