<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="CapaPresentecionWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp; Datos del Alumno<br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp; Apellidos:&nbsp;&nbsp;
            <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp; Nombres:&nbsp;&nbsp;
            <asp:TextBox ID="txtNombres" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp; Edad:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnReporte" runat="server" Text="Reporte" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblResultado" runat="server" Text="Label"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
