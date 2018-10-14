<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/MainMaster.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="WebWareHouse.AdminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 100%;
            height: 400px;
        }
        .auto-style5 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style4">
        <tr>
            <td class="auto-style5" style="text-align: center">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="XX-Large" Font-Underline="True" Text="Go To Database Link To Manipulate The Database"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
        </tr>
    </table>
</asp:Content>
