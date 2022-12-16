<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="ASPClase.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">  
    <div class="cal">
        <asp:Label ID="label" Text="Calculadora" runat="server"></asp:Label>  
        <br />

        <asp:TextBox ID="textBox" runat="server" Width="200px" Height="30px"></asp:TextBox>  
        <br />

        <asp:Button ID="boton1" Text="1" runat="server" Height="37px" Width="57px" OnClick="clickNumero" />  
        <asp:Button ID="boton2" Text="2" runat="server" Height="37px" Width="57px" OnClick="clickNumero" />  
        <asp:Button ID="boton3" Text="3" runat="server" Height="37px" Width="57px" OnClick="clickNumero" />  
        <asp:Button ID="sumar" Text="+" runat="server" Height="37px" Width="57px" OnClick="clickOperacion" />  
        <br />

        <asp:Button ID="boton4" Text="4" runat="server" Height="37px" Width="57px" OnClick="clickNumero" />  
        <asp:Button ID="boton5" Text="5" runat="server" Height="37px" Width="57px" OnClick="clickNumero" />  
        <asp:Button ID="boton6" Text="6" runat="server" Height="37px" Width="57px" OnClick="clickNumero" />  
        <asp:Button ID="restar" Text="-" runat="server" Height="37px" Width="57px" OnClick="clickOperacion" />  
        <br />

        <asp:Button ID="boton7" Text="7" runat="server" Height="37px" Width="57px" OnClick="clickNumero" />  
        <asp:Button ID="boton8" Text="8" runat="server" Height="37px" Width="57px" OnClick="clickNumero" />  
        <asp:Button ID="boton9" Text="9" runat="server" Height="37px" Width="57px" OnClick="clickNumero" />  
        <asp:Button ID="multiplicar" Text="*" runat="server" Height="37px" Width="57px" OnClick="clickOperacion" />  
        <br />

        <asp:Button ID="boton0" runat="server" Text="0" Height="37px" Width="57px" OnClick="clickNumero" />  
        <asp:Button ID="clear" runat="server" Text="CLR" Height="37px" Width="57px" OnClick="clickClear" />  
        <asp:Button ID="igual" runat="server" Text="=" Height="37px" Width="57px" OnClick="clickResultado" />  
        <asp:Button ID="dividir" Text="/" runat="server" Height="37px" Width="57px" OnClick="clickOperacion" />  
        <br />

        <asp:Label ID="errores" runat="server"></asp:Label>  
    </div>  
    </form>
</body>
</html>
