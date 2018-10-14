<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/MainMaster.Master" AutoEventWireup="true" CodeBehind="SearchPage.aspx.cs" Inherits="WebWareHouse.SearchPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridViewSearch" runat="server" AutoGenerateColumns="False" Height="420px" Width="792px" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
   
        <AlternatingRowStyle BackColor="#DCDCDC" />
   
        <Columns>

            <asp:TemplateField HeaderText="ID">  
             <ItemTemplate>  
                 <asp:Label ID="lblId" runat="server" Text='<%#Bind("boo_id") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>  
         <asp:TemplateField HeaderText="Title">  
             <ItemTemplate>  
                 <asp:Label ID="lblTitle" runat="server" Text='<%#Bind("boo_title") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>  
         <asp:TemplateField HeaderText="Price">  
             <ItemTemplate>  
                 <asp:Label ID="lblPrice" runat="server" Text='<%#Bind("boo_price") %>'></asp:Label>  
             </ItemTemplate>  
         </asp:TemplateField>  
         <asp:TemplateField HeaderText="Special">  
             <ItemTemplate>  
                 <asp:Label ID="lblSpecial" runat="server" Text='<%#Bind("boo_special") %>'></asp:Label>  
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
</asp:Content>
