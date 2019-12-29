<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <script type="text/javascript">
        function f1() {
            sweetAlert("Sorry...", "User Not Found!!", "error");
        }
        function f2() {
            sweetAlert("Sorry...", "UserName or Password May be Wrong!!", "error");
        }
     </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     
          <asp:TextBox ID="TextBoxUNLogin" runat="server" value="Username"></asp:TextBox>
          <br />
          <asp:TextBox ID="TextBoxPass" TextMode="Password" runat="server" placeholder="Password" required="required"></asp:TextBox>
         <br />

			 <label>
           <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Remember Me?" />
              </label>
              <br />
        <asp:Button ID="ButtonLogin" runat="server" OnClick="ButtonLogin_Click" Text="LOG IN " />

    </div>
    </form>
</body>
</html>
