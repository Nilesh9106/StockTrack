<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="StockTrackClient.home" EnableEventValidation="false" MasterPageFile="~/Site.Master" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <title>Home | StockTrack</title>
</asp:Content>

<asp:Content ContentPlaceHolderID="body" runat="server">


    <asp:Repeater ID="products" runat="server">
        <HeaderTemplate>
            <h1>Products</h1>
            <div class="accordion" id="accordion">
        </HeaderTemplate>
        <ItemTemplate>
            <asp:Label ID="itemId" runat="server"  Text='<%#Eval("Id")%>' Visible="false"> </asp:Label>
            <div class="accordion-item">
                <h2 class="accordion-header">
                    <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapse<%#Eval("Id") %>" aria-expanded="false"  aria-controls="collapse<%#Eval("Id") %>">
                        <%#Eval("Name") %> - <%#Eval("Brand") %>
                    </button>
                </h2>
                <div id="collapse<%#Eval("Id") %>" class="accordion-collapse collapse " data-bs-parent="#accordion">
                    <div class="accordion-body">
                        <div class="card" style="width: 100%;">
                            <ul class="list-group list-group-flush">
                                <li class="list-group-item">Description : <%#Eval("Description") %></li>
                                <li class="list-group-item">Price : <%#Eval("Price") %></li>
                                <li class="list-group-item">Qty : <%#Eval("Qty") %></li>
                                <li class="list-group-item">Category : <%#Eval("Category") %></li>
                            </ul>
                            <div class="card-body d-flex gap-2">
                                <a href="/Products/edit.aspx?Id=<%#Eval("Id") %>" class="btn btn-dark">Edit</a>
                                <a href="/Transactions/view.aspx?ProductId=<%#Eval("Id") %>" class="btn btn-dark">Transactions</a>
                                <asp:Button CssClass="btn btn-danger" runat="server" ID="btnDelete" Text="Delete" OnClick="btnDelete_Click" OnClientClick="return confirm('are you to delete Product??')"  />
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
