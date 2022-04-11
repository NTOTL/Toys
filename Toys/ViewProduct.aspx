<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="Toys.ViewProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>View Product</h3>
    <div class="row">
        <div class="col-sm-3">
            <asp:Image ID="imgProduct" runat="server" />
        </div>
        <div class="col-sm-2">
            <asp:Label ID="lblProductName" runat="server">Product: </asp:Label>
            <asp:Label ID="lblProductDescription" runat="server">Description: </asp:Label>
            <br />
            <asp:Label ID="lblUnitPrice" runat="server">Unit price: </asp:Label>
            <br />
            <asp:Label ID="lblCategoryName" runat="server">Category: </asp:Label>
            <br />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-4">
            <asp:Button ID="btnReturn" runat="server" Text="Go Back" CssClass="btn btn-primary" />
        </div>
    </div>
</asp:Content>
