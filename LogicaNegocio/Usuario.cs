using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LogicaNegocio
{
    
    public class Usuario
    {
        static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        static SqlConnection cn = new SqlConnection(cadena);

        public int codUsuario { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }

        public Empleado empleado = new Empleado();

        public bool LoguearUsuario()
        {
            try
            {
                string sql = "Select * From Usuario Where Usuario=@usuario and Contraseña=@contraseña";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet data = new DataSet();
                byte i = Convert.ToByte(da.Fill(data));
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
        public bool ExisteUsuario()
        {
            try
            {
                string sql = "Select * From Usuario Where Usuario=@usuario";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@usuario", usuario);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet data = new DataSet();
                byte i = Convert.ToByte(da.Fill(data));
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
        public string DesencriptarContraseña()
        {
            string contraseña = "";
            try
            {
                string sql = "spDesencripta";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codUsuario",codUsuario);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    contraseña = dr["CONTRASEÑA"].ToString();
                }
                cn.Close();
                return contraseña;
            }
            catch
            {
                return contraseña="";
            }
            finally
            {
                cn.Close();
            }
        }
        public int DevuelveCodUsuLogueado()
        {
            try
            {
                string sql = "spDevuelveCodUsuLogueado";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", usuario);
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
        public int DevuelveCodUsu(int codEmpleado)
        {
            try
            {
                string sql = "spDevuelveCodUsu";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codEmpleado", codEmpleado);
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


        




    }
}
