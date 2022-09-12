using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWEB
{
    public partial class Loguear : System.Web.UI.Page
    {

        //ServiceReference1.ServiceWCFClient servicio = new ServiceReference1.ServiceWCFClient();
        ServiceReferenceLoguear.WebServiceSoapClient servicioLoguear = new ServiceReferenceLoguear.WebServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            int codUsu = servicioLoguear.DevuelveCodUsuLogueado(usuario);
            if (servicioLoguear.ExisteUsuario(usuario))
            {
                string contraDesencript = servicioLoguear.DesencriptarContraseña(codUsu, usuario);
                if (contraDesencript.Equals(contraseña))
                {
                    Response.Redirect("ListadoEmpleados.aspx?codUsuLogueado=" + servicioLoguear.DevuelveCodUsuLogueado(usuario));
                }
                else
                {
                    Response.Write("<script>alert('Usuario y/o Contraseña Incorrecto')</script>");
                }
            }
            else
                Response.Write("<script>alert('Usuario no registrado')</script>");
        }
    }
}