<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Signin.aspx.cs" Inherits="Toys.Signin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <label for="txtEmail">Email: </label>
        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
        <label for="txtPassword">Password: </label>
        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" ClientIDMode="Static" TextMode="Password">
        </asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Button ID="btnSignin" runat="server" CssClass="btn btn-primary" Text="Sign In" OnClick="btnSignin_Click" />
        <asp:Label ID="lblSigninFailed" runat="server" CssClass="alert alert-danger" Visible="false"></asp:Label>
    </div>
</asp:Content>
