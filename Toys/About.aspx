<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Toys.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <p>
        <asp:TextBox ID="txtFirstName" runat="server" ClientIDMode="Static"></asp:TextBox>
    </p>
<p>
        <asp:Button ID="btnSubmit" runat="server" ClientIDMode="Static" OnClick="btnSubmit_Click" Text="Submit" />
    </p>
</asp:Content>
