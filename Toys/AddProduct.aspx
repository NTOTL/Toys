<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="Toys.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Add New Product</h3>
    <div class="form-group">
        <label for="txtProductName">Product Name:</label>
        <asp:TextBox ID="txtProductName" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
        <label for="txtProductDescription">Description:</label>
        <asp:TextBox ID="txtProductDescription" runat="server" ClientIDMode="Static" CssClass="form-control" TextMode="MultiLine" Rows="3">
        </asp:TextBox>
        <label for="txtUnitPrice">Price:</label>
        <asp:TextBox ID="txtUnitPrice" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
        <label for="fuProductImage">Product Image: </label>
        <asp:FileUpload ID="fuProductImage" runat="server" ClientIDMode="Static" CssClass="form-control-file" />
        <label for="ddlCategories">Category: </label>
        <asp:DropDownList ID="ddlCategories" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:DropDownList>
    </div>
    <div class="form-group">
        <asp:Button ID="btnAddProduct" runat="server" ClientIDMode="Static" CssClass ="btn btn-primary" Text="Add Product" OnClick="btnAddProduct_Click" />
    </div>
</asp:Content>
