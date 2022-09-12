<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loguear.aspx.cs" Inherits="appWEB.Loguear" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width-=device-width,initial-scale=1.0"/>
    <link href="dist(bootstrap)/css/bootstrap-theme.css" rel="stylesheet" />
    <link href="dist(bootstrap)/css/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" >
        <br />
        <div class="container" align="center">
             <img alt="" src="login.png" width="150" align="center"/> 
        </div>
            <br />
        <div class="container" align="center">
            Usuario: <asp:TextBox ID="txtUsuario" runat="server" align="center" CssClass="form-control center-block" Width="200" placeholder="nombre de usuario"/><br />
            Contraseña:<asp:TextBox ID="txtContraseña" runat="server" align="center" CssClass="form-control center-block" Width="200" TextMode="Password" placeholder="contraseña"/><br />
            <asp:Button id="btnIniciar" runat="server" Text="Iniciar" align="center" CssClass="btn btn-warning center-block" OnClick="btnIniciar_Click"/>
        </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <footer class="modal-footer">
            <p class="form-control btn-danger">
                <b><marquee>Integrantes:   Juan Chumpitaz  -   Ana Calderon </marquee></b>
            </p>
        </footer>
    </form>
</body>
</html>
