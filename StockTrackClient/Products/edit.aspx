<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="StockTrackClient.Products.edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Edit Product</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
     <div class="my-3 p-5 card">
    <h1>Edit Product</h1>
     <div class="my-2  form-group">
         <asp:Label ID="namelabel" CssClass="mb-2" runat="server" AssociatedControlID="name" Text="Name"></asp:Label>
         <asp:TextBox ID="name" CssClass="form-control" runat="server" TextMode="SingleLine"></asp:TextBox>
     </div>
     <div class="my-2 form-group">
         <asp:Label ID="labelDescription" CssClass="mb-2" runat="server" AssociatedControlID="desc" Text="Description"></asp:Label>
         <asp:TextBox ID="desc" CssClass="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
     </div>
     <div class="my-2 form-group">
         <asp:Label ID="label1" runat="server" CssClass="mb-2" AssociatedControlID="price" Text="Price"></asp:Label>
         <asp:TextBox ID="price" CssClass="form-control" runat="server" TextMode="Number"></asp:TextBox>
     </div>
     <div class="my-2 form-group">
         <asp:Label ID="label2" runat="server" CssClass="mb-2" AssociatedControlID="qty" Text="Quantity"></asp:Label>
         <asp:TextBox ID="qty" CssClass="form-control" runat="server" TextMode="Number"></asp:TextBox>
     </div>
     <div class="my-2 form-group">
         <asp:Label ID="label3" runat="server" CssClass="mb-2" AssociatedControlID="category" Text="Category"></asp:Label>
         <asp:TextBox ID="category" CssClass="form-control" runat="server" TextMode="SingleLine"></asp:TextBox>
     </div>
     <div class="my-2 form-group">
         <asp:Label ID="label4" runat="server" CssClass="mb-2" AssociatedControlID="brand" Text="Brand"></asp:Label>
         <asp:TextBox ID="brand" CssClass="form-control" runat="server" TextMode="SingleLine"></asp:TextBox>
     </div>
     <asp:Button CssClass="btn btn-dark w-100" Text="Add" runat="server" ID="btn_add" OnClick="btn_add_Click"/>
 </div>
</asp:Content>
