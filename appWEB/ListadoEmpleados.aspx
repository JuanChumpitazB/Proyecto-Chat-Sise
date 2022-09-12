<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoEmpleados.aspx.cs" Inherits="appWEB.ListadoEmpleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width-=device-width,initial-scale=1.0"/>
    <link href="dist(bootstrap)/css/bootstrap-theme.css" rel="stylesheet" />
    <link href="dist(bootstrap)/css/bootstrap.min.css" rel="stylesheet" />
    <link href="dist(bootstrap)/css/Estilos.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <div class="titulo">Lista de Empleados</div>
    <div>
    
        <br />
        <br />
        <asp:GridView ID="gv_Empleados" align="center" runat="server" OnSelectedIndexChanged="gv_Empleados_SelectedIndexChanged" CssClass="table table-bordered" Width="500" color="#fff" BackColor="#04134D" ForeColor="#FF3300">
            <Columns>
                <asp:CommandField ShowSelectButton="True" ButtonType="Button" ControlStyle-CssClass="active" SelectText="Chatear">
<ControlStyle CssClass="active"></ControlStyle>
                </asp:CommandField>
            </Columns>
        </asp:GridView>
        <asp:Label ID="lblcodUsuLogueado" runat="server" Text="Label"></asp:Label>
        <asp:TextBox id="txtcodEmpleado" runat="server"/>
    </div>
        <div>
            <center><asp:Button ID="btnSalir" runat="server" Text="Salir" align="center" CssClass="btn btn-danger" OnClick="btnSalir_Click"/></center>
        </div>
    </form>
</body>
</html>
