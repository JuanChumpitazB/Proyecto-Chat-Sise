using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace appWEB
{
    public partial class Chat : System.Web.UI.Page
    {
        ServiceReferenceWCF.ServiceWCFClient servicio = new ServiceReferenceWCF.ServiceWCFClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["codUsuarioRecibe"] != null && Request.Params["codUsuarioEnvia"] != null)
            {
                lblcodUsuRecibe.Text = Request.Params["codUsuarioRecibe"];
                lblcodUsuEnvia.Text = Request.Params["codUsuarioEnvia"];
                int codUsuRecibe = Convert.ToInt32(lblcodUsuRecibe.Text);
                int codUsuEnvia = Convert.ToInt32(lblcodUsuEnvia.Text);

                lblNombreCompleto.Text = servicio.DevuelveDatosEmpleado(codUsuRecibe);

                lblcodUsuEnvia.Visible = false;
                lblcodUsuRecibe.Visible = false;

                CargarChat(codUsuEnvia,codUsuRecibe);

            }

            
        }
        private void CargarChat(int usuEnvia, int usuRecibe)
        {
            lstChat.DataSource = servicio.CargarConversacion(usuEnvia, usuRecibe).Tables[0];
            lstChat.DataTextField = servicio.CargarConversacion(usuEnvia, usuRecibe).Tables[0].Columns["Conversacion"].ToString();
            lstChat.DataValueField = servicio.CargarConversacion(usuEnvia, usuRecibe).Tables[0].Columns["Conversacion"].ToString();
            lstChat.DataBind();
            if(servicio.CargarConversacion(usuEnvia, usuRecibe).Tables[0].Rows.Count > 0)
            {
                string fechaHora = servicio.DevuelveFechaHoraUltiMensaje(usuEnvia);
                string nombreS = servicio.DevuelveDatosEmpleado(servicio.DevuelveCodUsuUltimoMensaje(usuEnvia));
                lblFechaHora.Text = fechaHora + "  |De: "+nombreS;
            }
            else
            {
                lblFechaHora.Text = "";
            }
            
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string mensaje = txtMensaje.Text;
            int codUsuRecibe = Convert.ToInt32(lblcodUsuRecibe.Text);
            int codUsuEnvia = Convert.ToInt32(lblcodUsuEnvia.Text);
            if (servicio.RegistrarConversacion(mensaje,codUsuEnvia,codUsuRecibe))
            {
                txtMensaje.Text = "";
                CargarChat(codUsuEnvia, codUsuRecibe);
            }
            else
            {
                Response.Write("<script>aler('Error!')</script>");
            }
        }

        protected void btnRefrescar_Click(object sender, EventArgs e)
        {
            int codUsuRecibe = Convert.ToInt32(lblcodUsuRecibe.Text);
            int codUsuEnvia = Convert.ToInt32(lblcodUsuEnvia.Text);
            CargarChat(codUsuEnvia, codUsuRecibe);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            string codUsuLogueado = lblcodUsuEnvia.Text;
            Response.Redirect("ListadoEmpleados.aspx?codUsuLogueado="+codUsuLogueado);
        }
    }
}