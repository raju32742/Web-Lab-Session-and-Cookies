<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

     <script type="text/javascript">
        function f1()
        {
            sweetAlert("Oops...", "User Name Already Exist!!", "error");

        }
        function f2() {
            swal("Congratulation!", "Your Registration Completed!", "success");
        }
       
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>


         <label>User name</label>
          <asp:TextBox ID="TextBoxUN" runat="server"  placeholder="User Name" required="required"></asp:TextBox>
          <br />
        <label>Email</label>
             <asp:TextBox ID="TextBoxEM" runat="server" placeholder="raju@gmail.com" required="required"></asp:TextBox>
        <br />

        <label>Password</label>
             <asp:TextBox ID="TextBoxPASS" runat="server" OnTextChanged="TextBoxPASS_TextChanged" TextMode="Password" placeholder="Password" required="required"></asp:TextBox>

        <br />
      <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" OnClientClick="return ValidateRegForm();" Text="Register"/>

         <h3>Go to Login Page <a href="Login.aspx">Click here.</a></h3>
        </div>
    </form>
</body>
</html>
