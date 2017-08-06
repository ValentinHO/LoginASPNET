<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="centrar">
        <tbody>
            <tr>
                <td>Username</td>
                <td><asp:TextBox ID="t1" runat="server" CssClass="form-control"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Password</td>
                <td><asp:TextBox ID="t2" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click" CssClass="btn btn-primary" />
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Label ID="lblerror" runat="server" CssClass="text-danger"></asp:Label>
                </td>
            </tr>
        </tbody>
    </table>
</asp:Content>

