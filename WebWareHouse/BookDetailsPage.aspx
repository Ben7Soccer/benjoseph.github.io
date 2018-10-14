<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/MainMaster.Master" AutoEventWireup="true" CodeBehind="BookDetailsPage.aspx.cs" Inherits="WebWareHouse.BookDetailsPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 235%;
            height: 434px;
        }
        .auto-style5 {
        }
        .auto-style6 {
            width: 222px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style4">
        <tr>
            <td class="auto-style5">
                <asp:Label ID="lblAddedMessage" runat="server" Font-Italic="True" ForeColor="#006699" Text="To See The Added Book ,Go To SHOPPING CART"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">    <asp:DetailsView ID="DetailsViewBook" runat="server" HeaderText="BOOK DETAILS" OnItemCommand="DetailsViewBook_ItemCommand"  AutoGenerateRows="False" Height="590px" Width="572px" Font-Bold="True" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" OnItemDeleting="DetailsViewBook_ItemDeleting" OnPageIndexChanging="DetailsViewBook_PageIndexChanging">
    
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <EditRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
    
        <Fields>
            <asp:BoundField DataField="Id" HeaderText="Id"/>
            <asp:BoundField DataField="Title" HeaderText="Title" />
            <asp:BoundField DataField="Price" HeaderText="Price"/>
            <asp:BoundField DataField="Special" HeaderText="Special" />
            <asp:ButtonField Text="Add To Cart" ButtonType="Button" />
        </Fields>

        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />

    </asp:DetailsView>
            </td>
        </tr>
    </table>
</asp:Content>
