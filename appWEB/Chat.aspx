<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chat.aspx.cs" Inherits="appWEB.Chat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width-=device-width,initial-scale=1.0"/>
    <link href="dist(bootstrap)/css/bootstrap-theme.css" rel="stylesheet" />
    <link href="dist(bootstrap)/css/bootstrap.min.css" rel="stylesheet" />
    <link href="dist(bootstrap)/css/Estilos.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" >
    <div style="margin-left: 40px">
    <div class="container center-block" >
        <div class="">
            <br />
            <h2><asp:Label ID="lblOpcional" runat="server" Text="Mensaje para: " ForeColor="Black"></asp:Label></h2>
            <h2><asp:Label ID="lblNombreCompleto" runat="server" Text="Label" ForeColor="#003366"></asp:Label></h2>
            Ultimo mensaje a las: <asp:Label ID="lblFechaHora" runat="server" Text="Label" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
            <br />
            <asp:ListBox ID="lstChat" align="center" runat="server" Height="155px" Width="438px" border="10"></asp:ListBox>
            
        </div>
        <br />
        <div class="form-inline" role="form">
            <p >
                <asp:TextBox ID="txtMensaje" align="center" runat="server" Width="382px" placeholder="Mensaje" CssClass="form-control"></asp:TextBox> 
                <asp:Button ID="btnEnviar" align="center" runat="server" Text="Enviar" OnClick="btnEnviar_Click" CssClass="btn btn-info" />
            </p>
        </div>
        <br />
        <asp:Button ID="btnRefrescar" runat="server" Text="Refrescar" OnClick="btnRefrescar_Click" CssClass="btn btn-success"/><br /><br />
        <asp:Button ID="btnVolver" runat="server" Text="<- Volver" CssClass="btn btn-danger" OnClick="btnVolver_Click"/>
        <br />
        <asp:Label ID="lblcodUsuRecibe" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="lblcodUsuEnvia" runat="server" Text="Label"></asp:Label><br />
    </div>
    </div>
    </form>
</body>
</html>
