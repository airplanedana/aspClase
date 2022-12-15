<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DanaASP.aspx.cs" Inherits="ASPClase.DanaASP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>  
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" />

        <asp:GridView ID="GridView1" runat="server"></asp:GridView>

        <h2>Selecciona fecha del calendario</h2>  
        <div>  
            <asp:Calendar ID="Calendar1" runat="server"   
            OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>  
        </div>  
    </form>  
    <p>  
        <asp:Label runat="server" ID="ShowDate" ></asp:Label>  
    </p>  
</body>
</html>
