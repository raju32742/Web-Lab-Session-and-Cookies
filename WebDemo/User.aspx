<%@ Page Language="C#" AutoEventWireup="true" CodeFile="User.aspx.cs" Inherits="User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

  User Name : <asp:Label ID="LabelUN" runat="server" CssClass="bb" Text="Label"></asp:Label>
    <br />
  Email:<input type="text" class="bb" id="TextBoxEM" />
           <br />
   Pass<input type="text" class="bb" id="TextBoxPA"/>
           <br />
         <input type="button" id="b1" class="B_design3" value="update" onclick="Update()"/>
        
        <br />
    </div>
    </form>

        <script type="text/javascript">

         function Update() {
             var NEm = document.getElementById("TextBoxEM").value;
             var NPa = document.getElementById("TextBoxPA").value;
             var xmlhttp = new XMLHttpRequest();
             xmlhttp.open("GET", "UserUpdate.aspx?NFn=" + NFn + "&NLn=" + NLn + "&NBd=" + NBd + "&NEm=" + NEm + "&NMn=" + NMn + "&NPa=" + NPa + "&opr=update", false);
             xmlhttp.send(null);
             alert("data update successfully");
       
         }


    </script>

</body>
</html>
