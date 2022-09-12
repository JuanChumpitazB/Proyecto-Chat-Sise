using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Data;
using LogicaNegocio;
/// <summary>
/// Descripción breve de WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod(Description ="Loguear")]
    public bool LoguearUsuario(string usu, string contra)
    {
        Usuario usuario = new Usuario();
        usuario.usuario = usu;
        usuario.contraseña = contra;
        return usuario.LoguearUsuario();
    }
    [WebMethod(Description ="ExisteUsuario")]
    public bool ExisteUsuario(string usu)
    {
        Usuario usuario = new Usuario();
        usuario.usuario = usu;
        return usuario.ExisteUsuario();
    }
    [WebMethod(Description ="DesemcriptarContraseña")]
    public string DesencriptarContraseña(int codUsu, string usu)
    {
        Usuario usuario = new Usuario();
        usuario.codUsuario = codUsu;
        usuario.usuario = usu;
        return usuario.DesencriptarContraseña();
    }
    [WebMethod(Description = "DevuelveCodUsuLogueado")]
    public int DevuelveCodUsuLogueado(string usu)
    {
        Usuario usuario = new Usuario();
        usuario.usuario = usu;
        return usuario.DevuelveCodUsuLogueado();
    }
    [WebMethod(Description ="DevuelveCodUsuXcodEmpleado")]
    public int DevuelveCodUsu(int codEmpleado)
    {
        Usuario usuario = new Usuario();
        usuario.empleado.codEmpleado = codEmpleado;
        return usuario.DevuelveCodUsu(codEmpleado);
    }
    

}
