<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="Toys.Categories" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Manage Categories</h2>
    <asp:Panel ID="pnlAddCategories" runat="server" ClientIDMode="Static">
        <div class="row">
            <div class="col-sm-2">
                <label for="txtCategoryName">Category Name: </label>
            </div>
            <div class="col-sm-10">
                <asp:TextBox ID="txtCategoryName" runat="server" placeholder="Please enter a name"></asp:TextBox>
                <asp:Label ID="lblFeedback" runat="server" Visible="False"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvCategoryName" runat="server" ControlToValidate="txtCategoryName" ErrorMessage="Required" ForeColor="Red" ValidationGroup="AddCategory"></asp:RequiredFieldValidator>

            </div>
        </div>

        <br />
        <div class="row">
            <div class="col-sm-12">
                <asp:Button ID="btnAddCategory" runat="server" Text="Add" CssClass="btn btn-primary" OnClick="btnAddCategory_Click" ValidationGroup="AddCategory" />
                <asp:Button ID="btnSaveCategory" runat="server" CssClass="btn btn-primary" OnClick="btnSaveCategory_Click" Text="Save" Visible="False" />
                <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-secondary" OnClick="btnCancel_Click" Text="Cancel" Visible="False" />
                <asp:Label ID="lblCategoryId" runat="server" Visible="False"></asp:Label>
            </div>
        </div>
    </asp:Panel><br />
    <asp:Panel ID="pnlCategoryList" runat="server">
        <asp:GridView ID="gvCategoryList" runat="server" CssClass="table table-striped" AutoGenerateColumns="False" OnRowCommand="gvCategoryList_RowCommand" OnRowDataBound="gvCategoryList_RowDataBound">
            <Columns>
                <asp:BoundField DataField="CategoryId" HeaderText="ID" />
                <asp:BoundField DataField="CategoryName" HeaderText="Category Name" />
                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                        <asp:Button ID="btnEdit" runat="server" CssClass="btn btn-primary" Text="Edit" CommandName="EditCategory" />
                        <asp:Button ID="btnDelete" runat="server" CssClass="btn btn-danger" 
                            OnClientClick="return confirm('Are you sure you want to delete this category?')" Text="Delete" CommandName="DeleteCategory" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

    </asp:Panel>
</asp:Content>
