<%@ Page Title="" Language="C#" MasterPageFile="~/pages/mainMaster.master" AutoEventWireup="true" CodeFile="book-list.aspx.cs" Inherits="pages_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <div class="col-md-2 mb-4">
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" >
                <asp:ListItem Value="0">Select Book Category</asp:ListItem>
                <asp:ListItem Value="2">Engineering</asp:ListItem>
                <asp:ListItem Value="3">Medical</asp:ListItem>
                <asp:ListItem Value="4">Competitive Exams</asp:ListItem>
                <asp:ListItem Value="5">School Level</asp:ListItem>
                <asp:ListItem Value="6">Science and Arts</asp:ListItem>
                 <asp:ListItem Value="6">Novels</asp:ListItem>
                <asp:ListItem Value="7">Others</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div id="books" runat="server"></div>
    </div>
<asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </asp:Content> 

