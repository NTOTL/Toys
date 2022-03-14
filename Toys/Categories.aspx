<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="Toys.Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Manage Categories</h2>
    <asp:Panel ID="pnlAddCategories" runat="server" ClientIDMode="Static">
        <label for="txtCategoryName">Category Name: </label>
        <asp:TextBox ID="txtCategoryName" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnAddCategory" runat="server" Text="Add" OnClick="btnAddCategory_Click" />
    </asp:Panel>
</asp:Content>
