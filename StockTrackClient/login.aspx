<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="StockTrackClient.login" MasterPageFile="~/Site.Master" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <title>Login | StockTrack</title>
</asp:Content>

<asp:Content ContentPlaceHolderID="body" runat="server">
    <div class="my-5 table-responsive">
        
        <table align="center" class="w-100 table table-hover">
            <tr>
                <td>
                    <asp:Label ID="emailLabel" runat="server" AssociatedControlID="emailInput" CssClass="form-label" Text="Email"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="emailInput" runat="server" CssClass="form-control" AutoCompleteType="Email" ></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="emailInput" ErrorMessage="Email is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="passwordLabel" runat="server" AssociatedControlID="passwordInput" CssClass="form-label" Text="Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="passwordInput" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="passwordInput" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <a href="signup.aspx">Don't have an account?</a>
                </td>
                <td>
                    <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-dark w-100" OnClick="btnLogin_Click" Text="Login" />
                </td>
                <td>
                    <asp:Label ID="errLabel" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
        
    </div>
</asp:Content>


