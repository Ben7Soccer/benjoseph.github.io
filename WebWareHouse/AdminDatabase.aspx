<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/MainMaster.Master" AutoEventWireup="true" CodeBehind="AdminDatabase.aspx.cs" Inherits="WebWareHouse.AdminDatabase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 100%;
        }
        .auto-style5 {
            height: 26px;
        }
        .auto-style6 {
            height: 463px;
        }
        .auto-style7 {
            height: 26px;
            width: 32px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style4">
        <tr>
            <td class="auto-style5" colspan="2">
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label1" runat="server" Text="Title"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label4" runat="server" Text="Price"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="Label3" runat="server" Text="Special"></asp:Label>
            </td>
            <td class="auto-style5">
                <asp:TextBox ID="txtSpecial" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6" colspan="2">
    <asp:GridView ID="AdminGridView" runat="server" DataKeyNames="boo_id"  Height="544px" Width="842px" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" OnPageIndexChanging="AdminGridView_PageIndexChanging" OnRowCancelingEdit="AdminGridView_RowCancelingEdit" OnRowDeleting="AdminGridView_RowDeleting" OnRowEditing="AdminGridView_RowEditing" OnRowUpdating="AdminGridView_RowUpdating">
    
        <AlternatingRowStyle BackColor="Gainsboro" />
    
    <Columns>
        <asp:BoundField HeaderText="Id" DataField="boo_id" ReadOnly="true" />
        <asp:BoundField HeaderText="Title" DataField="boo_title"/>
        <asp:BoundField HeaderText="Price" DataField="boo_price" />
        <asp:BoundField HeaderText="Special" DataField="boo_special"/>    

        <asp:TemplateField ShowHeader="false">
            <EditItemTemplate>
                <asp:LinkButton ID="linkbutton1" runat="server" CausesValidation="true" CommandName="Update"></asp:LinkButton>
            &nbsp;<asp:LinkButton ID="linkbutton2" runat="server" CausesValidation="false" CommandName="Cancel"></asp:LinkButton>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:LinkButton ID="linkbutton3" runat="server" CausesValidation="false" CommandName="Edit"></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField ShowHeader="true">
            <ItemTemplate>
                <asp:LinkButton ID="linkbutton4" runat="server" CausesValidation="false" CommandName="Delete"></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>

        </Columns>

        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />

    </asp:GridView>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
