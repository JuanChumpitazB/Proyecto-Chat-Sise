using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appWEB
{
    public partial class ListadoEmpleados : System.Web.UI.Page
    {
        ServiceReferenceWCF.ServiceWCFClient servicio = new ServiceReferenceWCF.ServiceWCFClient();
        ServiceReferenceLoguear.WebServiceSoapClient servicioLoguear = new ServiceReferenceLoguear.WebServiceSoapClient();
        static int codUsuLogueado = 0;  
        protected void Page_Load(object sender, EventArgs e)
        {
            txtcodEmpleado.Visible = false;
            lblcodUsuLogueado.Visible = false;

            if (Request.Params["codUsuLogueado"] != null)
            {
                codUsuLogueado = Convert.ToInt32(Request.Params["codUsuLogueado"]);
                lblcodUsuLogueado.Text = codUsuLogueado.ToString();
                
                Listar(codUsuLogueado);
            }
        }
        private void Listar(int codUsu)
        {
            gv_Empleados.DataSource = servicio.ListarEmpleado(codUsu).Tables[0];
            gv_Empleados.DataBind();
        }

        protected void gv_Empleados_SelectedIndexChanged(object sender, EventArgs e)
        {

            GridViewRow row = gv_Empleados.SelectedRow;
            //txtcodEmpleado.Text = row.Cells[1].Text.ToString();
            int codEmpleado = Convert.ToInt32(row.Cells[1].Text.ToString());
            int codUsuEnvia = Convert.ToInt32(lblcodUsuLogueado.Text);
            Response.Redirect("Chat.aspx?codUsuarioRecibe=" + servicioLoguear.DevuelveCodUsu(codEmpleado)+ "&codUsuarioEnvia=" + codUsuEnvia);

        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Loguear.aspx");
        }
    }
}