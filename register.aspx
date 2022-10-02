<%@ Page Title="" Language="C#" MasterPageFile="~/pages/mainMaster.master" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="pages_Default" %>

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
            Register
        </h5>
                <asp:TextBox id="TextBox1" required CssClass="form-control mb-3" Placeholder="Full Name" runat="server"></asp:TextBox>
        <asp:TextBox id="TextBox3" required CssClass="form-control mb-3" Placeholder="Mobile Number" runat="server"></asp:TextBox>
        <asp:TextBox id="TextBox4" required CssClass="form-control mb-3" Placeholder="Email Id" runat="server"></asp:TextBox>
        <asp:TextBox id="TextBox5" required CssClass="form-control mb-3" Placeholder="Address" runat="server"></asp:TextBox>
        <asp:TextBox id="TextBox2" required CssClass="form-control mb-3" Placeholder="Password" TextMode="password" runat="server"></asp:TextBox>
        <asp:TextBox id="TextBox7" required CssClass="form-control mb-3" Placeholder="Confirm Password" TextMode="password" runat="server"></asp:TextBox>
        <asp:Button Id="btn" CssClass="btn btn-success mr-2" runat="server" Text="Register" OnClick="btn_Click" />
        <a href="./login.aspx">Already have an account</a>
        </div>
      
        </div>
        </div>
</asp:Content>

