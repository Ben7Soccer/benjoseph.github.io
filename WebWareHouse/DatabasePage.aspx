<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/MainMaster.Master" AutoEventWireup="true" CodeBehind="DatabasePage.aspx.cs" Inherits="WebWareHouse.DatabasePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="BookGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="boo_id" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Height="705px" Width="1022px" OnSelectedIndexChanging="BookGridView_SelectedIndexChanging" AutoGenerateSelectButton="True" OnSelectedIndexChanged="BookGridView_SelectedIndexChanged" AllowPaging="True" OnPageIndexChanging="BookGridView_PageIndexChanging">
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
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
    </asp:GridView>
</asp:Content>
