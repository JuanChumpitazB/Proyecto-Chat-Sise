using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "ServiceWCF" en el código, en svc y en el archivo de configuración a la vez.
public class ServiceWCF : IServiceWCF
{
    static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
    static SqlConnection cn = new SqlConnection(cadena);

    public DataSet ListarEmpleado(int codUsuario)
    {
        string sql = "spMostrarEmpleados";
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@codUsuario",codUsuario);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet data = new DataSet();
        da.Fill(data);
        return data;
    }
    public string DevuelveDatosEmpleado(int codUsuario)
    {
        string nombreCompleto = "";
        try
        {
            string sql = "spDevuelveDatosEmpleado";
            SqlCommand cmd = new SqlCommand(sql,cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codUsuario",codUsuario);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                nombreCompleto = dr["nombres"].ToString()+ " " + dr["apellidos"].ToString();
            }
            cn.Close();
            return nombreCompleto;
        }
        catch
        {
            return nombreCompleto = "";
        }
        finally
        {
            cn.Close();
        }
    }

    

    
    //////////////////////////////-CONVERSACION-//////////////////////
    public DataSet CargarConversacion(int codUsuarioEnvia, int codUsuarioRecibe)
    {
        string sql = "spCargarConversacion";
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@codUsuarioEnvia", codUsuarioEnvia);
        cmd.Parameters.AddWithValue("@codUsuarioRecibe", codUsuarioRecibe);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet data = new DataSet();
        da.Fill(data);
        return data;
    }




    public bool RegistrarConversacion(string conversacion, int codUsuEnvia, int codUsuRecibe)
    {
        try
        {
            string sql = "spRegistrarConversacion";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@conversacion", conversacion);
            cmd.Parameters.AddWithValue("@codUsuarioEnvia", codUsuEnvia);
            cmd.Parameters.AddWithValue("@codUsuarioRecibe", codUsuRecibe);
            cn.Open();
            byte i = Convert.ToByte(cmd.ExecuteNonQuery());
            cn.Close();
            if (i == 1) return true;
            else return false;
        }
        catch
        {
            return false;
        }
        finally
        {
            cn.Close();
        }
    }


    public int DevuelveCodUsuUltimoMensaje(int codUsuEnvia)
    {
        try
        {
            string sql = "spDevuelveCodUsuUltimoMensaje";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codUsuEnvia", codUsuEnvia);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            int codUsu = 0;
            if (dr.Read())
            {
                codUsu = Convert.ToInt32(dr[0]);
                return codUsu;
            }
            else codUsu = 0;
            cn.Close();
            return codUsu;
        }
        catch
        {
            return 0;
        }
        finally
        {
            cn.Close();
        }
    }


    public string DevuelveFechaHoraUltiMensaje(int codUsuEnvia)
    {
        string fechaHora = "";
        try
        {
            string sql = "spDevuelveFechaHoraUltiMensaje";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codUsuEnvia", codUsuEnvia);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                fechaHora = dr["FECHAHORA"].ToString();
            }
            cn.Close();
            return fechaHora;
        }
        catch
        {
            return fechaHora="";
        }
        finally
        {
            cn.Close();
        }
    }



}
