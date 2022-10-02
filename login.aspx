<%@ Page Title="" Language="C#" MasterPageFile="~/pages/mainMaster.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="pages_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <style>
        *{
            font-family: sans-serif;
        }
    </style>
    <div class="container">
<div class="row">
    <div class="col-md-3">

        </div>
    <div class="col-md-6 shadow p-5">
        <h5> 
            Login
        </h5>
        <asp:TextBox id="txtbox1" CssClass="form-control mb-3" Placeholder="Email Id" runat="server" ValidateRequestMode="Enabled" required></asp:TextBox>
        <asp:TextBox id="TextBox2" CssClass="form-control mb-3" Placeholder="Password" TextMode="password" runat="server" CausesValidation="True"  required ValidateRequestMode="Enabled" ValidationGroup="required"></asp:TextBox>
        <asp:Button Id="btn" CssClass="btn btn-success mr-2" runat="server" Text="Login" OnClick="btn_Click" />
                <a href="./register.aspx">Create Account</a>

        </div>
      
        </div>
        </div>
</asp:Content>

