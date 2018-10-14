<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="WebWareHouse.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Styles/LoginStyle.css"/>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 207px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div class="login-page">
  <div class="form">
    
    
      <table class="auto-style1">
          <tr>
              <td class="auto-style2">
                  <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
              </td>
              <td>
                  <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
              </td>
          </tr>
          <tr>
              <td class="auto-style2">
                  <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
              </td>
              <td>
                  <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ValidateRequestMode="Enabled"></asp:TextBox>
              </td>
          </tr>
          <tr>
              <td class="auto-style2"> <asp:Button ID="btnAdminLogin" runat="server" Text="Login As Admin" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" OnClick="Button1_Click" /> </td>
              <td>
                  <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login As User" Font-Bold="True" Font-Names="Candara" Font-Size="Medium" />
              </td>
          </tr>
      </table>
    
    
  </div>
</div>

    </div>
    </form>
</body>
</html>
