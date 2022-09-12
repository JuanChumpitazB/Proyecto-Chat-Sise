using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data;
// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceWCF" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IServiceWCF
{
    //EMPLEADO
    [OperationContract]
    DataSet ListarEmpleado(int codUsuario);
    [OperationContract]
    string DevuelveDatosEmpleado(int codUsuario);
    
    
    //CONVERSACION
    [OperationContract]
    DataSet CargarConversacion(int codUsuarioEnvia, int codUsuarioRecibe);

    [OperationContract]
    bool RegistrarConversacion(string conversacion, int codUsuEnvia, int codUsuRecibe);
    [OperationContract]
    int DevuelveCodUsuUltimoMensaje(int codUsuEnvia);
    [OperationContract]
    string DevuelveFechaHoraUltiMensaje(int codUsuEnvia);
}

[DataContract]
public class Empleado
{
    int codEmpleado;
    string nombres;
    string apellidos;

    [DataMember]
    public int CodEmpleado
    {
        get { return codEmpleado; }
        set { codEmpleado = value; }
    }
    [DataMember]
    public string Nombres
    {
        get { return nombres; }
        set { nombres = value; }
    }
    [DataMember]
    public string Apellidos
    {
        get { return apellidos; }
        set { apellidos = value; }
    }
}
[DataContract]
public class Usuario
{
    int codUsuario;
    string usuarioNom;
    string contraseña;
    Empleado empleado;

    [DataMember]
    public int CodUsuario
    {
        get { return codUsuario; }
        set { codUsuario = value; }
    }
    [DataMember]
    public string UsuarioNom
    {
        get { return usuarioNom; }
        set { usuarioNom = value; }
    }
    [DataMember]
    public string Contraseña
    {
        get { return contraseña; }
        set { contraseña = value; }
    }
    [DataMember]
    public Empleado Empleado
    {
        get { return empleado; }
        set { empleado = value; }
    }
}
[DataContract]
public class Conversacion
{
    int codConversacion;
    DateTime fecha;
    string hora;
    string conversacionN;
    Usuario usuarioEnvia;
    Usuario usuarioRecibe;

    [DataMember]
    public int CodConversacion
    {
        get { return codConversacion; }
        set { codConversacion = value; }
    }
    [DataMember]
    public DateTime Fecha
    {
        get { return fecha; }
        set { fecha = value; }
    }
    [DataMember]
    public string Hora
    {
        get { return hora; }
        set { hora = value; }
    }
    [DataMember]
    public string ConversacionN
    {
        get { return conversacionN; }
        set { conversacionN = value; }
    }
    [DataMember]
    public Usuario UsuarioEnvia
    {
        get { return usuarioEnvia; }
        set { usuarioEnvia = value; }
    }
    [DataMember]
    public Usuario UsuarioRecibe
    {
        get { return usuarioRecibe; }
        set { usuarioRecibe = value; }
    }
}
