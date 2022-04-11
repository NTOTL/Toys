<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Toys._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>My Lovely Toys</h1>        
    </div>  
    
    <asp:PlaceHolder ID="phToys" runat="server">

    </asp:PlaceHolder>

</asp:Content>
